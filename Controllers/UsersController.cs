using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestLogging.Models;

namespace MVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;
        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        public IActionResult Create()
        {
            var user = new Person()
            {
                FirstName = "Ali",
                LastName = "Ezadkhaha"
            };
            _logger.LogInformation(1,$"User with fullname:{user.FirstName} {user.LastName} was created!");
            return Content("");
        }
        public IActionResult SignOff()
        {
            var user = new Person()
            {
                FirstName = "Ali",
                LastName = "Ezadkhaha"
            };
            _logger.LogInformation(2, $"User with fullname:{user.FirstName} {user.LastName} logged out!");

            return Content("");
        }
    }
}
