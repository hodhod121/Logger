using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestLogging.Models;

namespace TestLogging.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly ILogger _logger;

        //public HomeController(ILogger<HomeController> logger)
        public HomeController(ILoggerFactory logger)
        {
           // _logger = logger;
            _logger = logger.CreateLogger("Home controller");
        }

        public IActionResult Index()
        {
            _logger.Log(LogLevel.Information, "Information log level");
            _logger.LogInformation("Information log ... 123");
            _logger.LogWarning("User test access denied");
            try
            {
                var n1 = 8;
                var number = n1 / 0;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex,"Something wrong in the application");
            }
            _logger.LogCritical("Your hard disk is out of disk space!");
            _logger.LogDebug("Logging with debug level");
            _logger.LogTrace("Logging with trace level");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
