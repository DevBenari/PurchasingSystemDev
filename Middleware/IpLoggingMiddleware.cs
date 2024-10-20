using Serilog;

namespace PurchasingSystemApps.Middleware
{
    public class IpLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private static bool _isFirstRequest = true;

        public IpLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (_isFirstRequest)
            {
                var userIp = context.Connection.RemoteIpAddress?.ToString();

                var loggerPath = $"C:/Users/USER/Documents/Serilog-{userIp}-.csv";

                Log.Logger = new LoggerConfiguration()
                    .WriteTo.File(loggerPath, rollingInterval: RollingInterval.Day)
                    .CreateLogger();

                Log.Information($"logger has been upload file with Ip : {userIp}");

                _isFirstRequest = false;
            }

            await _next(context);
        }

    }
}
