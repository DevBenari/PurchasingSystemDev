using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using PurchasingSystemApps.Areas.MasterData.Repositories;
using PurchasingSystemApps.Data;
using PurchasingSystemApps.Models;
using PurchasingSystemApps.ViewModels;
using System.Net;
using System.Security.Claims;
using UAParser;

namespace PurchasingSystemApps.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private ILogger<AccountController> _logger;
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IUserActiveRepository _userActiveRepository;

        public AccountController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ApplicationDbContext applicationDbContext,
            IUserActiveRepository userActiveRepository,
            ILogger<AccountController> logger)
        {
            _applicationDbContext = applicationDbContext;
            _signInManager = signInManager;
            _userManager = userManager;
            _userActiveRepository = userActiveRepository;
            _logger = logger;
        }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }
        public IActionResult Index()
        {            
            return View();
        }


        [HttpPost]
        [Route("accountController/ExtendSession")]
           public IActionResult ExtendSession()
        {
            // Memperpanjang session dengan memperbarui waktu aktivitas terakhir
            HttpContext.Session.SetString("LastActivity", DateTime.Now.ToString());

            return Ok();
        }

        [HttpPost]
        [Route("accountController/EndSession")]
        public async Task<IActionResult> EndSession()
        {
            

            var getUser = _userActiveRepository.GetAllUserLogin().Where(u => u.UserName == User.Identity.Name).FirstOrDefault();
            var user = await _signInManager.UserManager.FindByNameAsync(getUser.Email);

            var loginTime = HttpContext.Session.GetString("LoginTime");
            if (DateTime.TryParse(loginTime, out DateTime loginTimes)) ;
            {
                var logoutTime = DateTime.Now;
                var duration = logoutTime - loginTimes;

                _logger.LogInformation($"User {user.NamaUser} has logged out on {logoutTime}. Login duration: {duration} hours");
            }

            HttpContext.Session.Clear();
            // Hapus authentication cookies jika ada
            Response.Cookies.Delete(".AspNetCore.Identity.Application");

            return Ok();
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            var response = new LoginViewModel();
            return View(response);
            //return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                var user = await _signInManager.UserManager.FindByNameAsync(model.Email);
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Invalid Login Attempt. ");
                    TempData["WarningMessage"] = "Sorry, Username & Password Not Registered !";
                    return View(model);
                }
                else if (user.IsActive == true) 
                {
                    var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
                    if (result.Succeeded)
                    {
                        var claims = new List<Claim>
                    {
                        new Claim("amr", "pwd"),
                    };

                        var roles = await _signInManager.UserManager.GetRolesAsync(user);

                        if (roles.Any())
                        {
                            var roleClaim = string.Join(",", roles);
                            claims.Add(new Claim("Roles", roleClaim));
                        }

                        await _signInManager.SignInWithClaimsAsync(user, model.RememberMe, claims);
                        // menyimpan data user yang sedang login berdasarkan NamaUser dan KodeUser
                        HttpContext.Session.SetString("FullName", user.NamaUser);
                        HttpContext.Session.SetString("KodeUser", user.KodeUser);

                        var loginTime = DateTime.Now;
                        HttpContext.Session.SetString("LoginTime", loginTime.ToString());


                        user.IsOnline = true;

                        await _userManager.UpdateAsync(user);
                        // kode untuk user yang login mendapatkan ip address
                        var userIpAddress = HttpContext.Connection.RemoteIpAddress?.ToString();
                        if (userIpAddress == "::1")
                        {
                            userIpAddress = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();
                        }

                        // mendapatkan browser dan device yang sedang digunakan 
                        var userBrowser = HttpContext.Request.Headers["User-Agent"].ToString();
                        var uaParser = Parser.GetDefault();
                        ClientInfo client = uaParser.Parse(userBrowser);

                        var BrowserName = client.UA.Family;
                        var versionBrowser = client.UA.Major;
                        string DeviceName = client.Device.Family;
                        if(DeviceName == "Other")
                        {
                            if (userBrowser.Contains("Windows NT", StringComparison.OrdinalIgnoreCase))
                                DeviceName = "Windows PC";
                            else if (userBrowser.Contains("iPhone", StringComparison.OrdinalIgnoreCase))
                                DeviceName = "iPhone";
                            else if (userBrowser.Contains("Android", StringComparison.OrdinalIgnoreCase))
                                DeviceName = "Android Device";
                            else if (userBrowser.Contains("Mac", StringComparison.OrdinalIgnoreCase))
                                DeviceName = "Mac";
                            else
                                DeviceName = "Unknown";
                        }

                        _logger.LogInformation($"user {user.NamaUser} has successfully logged in with IP {userIpAddress.ToString()} at {loginTime}  ");      
                        _logger.LogInformation($"User  logged in on browser : {BrowserName} version {versionBrowser} with device: {DeviceName}");
                        return RedirectToAction("Index", "Home");
                    }
                    else if (result.RequiresTwoFactor)
                    {
                        return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, model.RememberMe });
                    }

                    else if (result.IsLockedOut)
                    {
                        _logger.LogWarning("User account locked out.");
                        // HttpContext.session.Clear untuk menghapus session data pengguna tidak lagi tersimpan
                        HttpContext.Session.Clear();
                        return RedirectToPage("./Lockout");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                        TempData["WarningMessage"] = "Sorry, Wrong Password !";
                        return View(model);
                    }
                }
                else
                {
                    TempData["UserActiveMessage"] = "Sorry, your user is not active !";
                    return View(model);
                }
                
                //if (result.Succeeded)
                //{
                //    _logger.LogInformation("User Loggin in.");
                //    return RedirectToAction("Index", "Home");
                //}                
            }
            return View(model);
        }

     
    }
}
