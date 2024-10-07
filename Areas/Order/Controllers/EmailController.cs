using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PurchasingSystemApps.Areas.MasterData.Repositories;
using PurchasingSystemApps.Areas.MasterData.ViewModels;
using PurchasingSystemApps.Areas.Order.Models;
using PurchasingSystemApps.Areas.Order.Repositories;
using PurchasingSystemApps.Areas.Order.ViewModels;
using PurchasingSystemApps.Data;
using PurchasingSystemApps.Models;
using System.Net.Mail;
using System.Net;

namespace PurchasingSystemApps.Areas.Order.Controllers
{
    [Area("Order")]
    [Route("Order/[Controller]/[Action]")]
    public class EmailController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IUserActiveRepository _userActiveRepository;

        private readonly IEmailRepository _emailRepository;

        public EmailController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ApplicationDbContext applicationDbContext,
            IUserActiveRepository userActiveRepository,
            IEmailRepository emailRepository
        )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _applicationDbContext = applicationDbContext;
            _userActiveRepository = userActiveRepository;
            _emailRepository = emailRepository;
        }
        public IActionResult Index()
        {
            var emails = _emailRepository.GetAllEmails(); // Ambil semua email dari repository
            return View(emails);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ViewResult> CreateEmail()
        {
            var model = new EmailViewModel(); // Gunakan EmailViewModel
            return View(model); // Mengirim model EmailViewModel ke tampilan
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateEmail(EmailViewModel model)
        {
            var getUser = _userActiveRepository.GetAllUserLogin().FirstOrDefault(u => u.UserName == User.Identity.Name);

            if (ModelState.IsValid)
            {
                // Ambil informasi file dari input
                var file = Request.Form.Files.FirstOrDefault();

                if (file != null && file.Length > 0)
                {
                    // Buat nama file unik
                    var uniqueFileName = $"{Guid.NewGuid()}_{file.FileName}";
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/email", uniqueFileName);

                    // Simpan file ke direktori
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    // Simpan informasi file ke database
                    var email = new Email
                    {
                        CreateDateTime = DateTime.Now,
                        CreateBy = new Guid(getUser.Id),
                        Emailid = Guid.NewGuid(),
                        To = model.To,
                        Subject = model.Subject,
                        Pesan = model.Pesan,
                        Status = "Terkirim",
                        AttachmentFileName = uniqueFileName // Simpan nama file unik ke database
                    };

                    _emailRepository.Tambah(email);
                    return RedirectToAction("Index");
                }
            }

            return View(model);
        }


    }
}
