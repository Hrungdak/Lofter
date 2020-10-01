using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lofter.Models;
using Functionalities.Contracts;
using Functionalities.Enums;

namespace Lofter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWeatherForecastDomainService _weatherForecastDomainService;

        public HomeController(ILogger<HomeController> logger, IWeatherForecastDomainService weatherForecastDomainService)
        {
            _logger = logger;
            _weatherForecastDomainService = weatherForecastDomainService;
        }

        public IActionResult Index()
        {
            return View(new HomeViewData { Title = "Home Data" });
        }

        public IActionResult Privacy()
        {
            return Content("Hello World");
            //return View();
        }

        public IActionResult Test()
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