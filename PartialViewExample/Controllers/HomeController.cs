using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartialViewExample.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register(Models.User veri)
        {
            var data = new Models.User();
            data.username = "huseyinyildiz";
            data.pass = "*********";
            return View(data);
        }
        public IActionResult Login(Models.User veri)
        {
            var data = new Models.User();
            data.Name = "Hüseyin";
            data.Surname = "Yıldız";
            data.Age = 25;
            return View(data);
        }
        public IActionResult Sum(Models.Numbers veri)
        {
            var data = new Models.Numbers();
            data.a = 5;
            data.b = 10;
            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
