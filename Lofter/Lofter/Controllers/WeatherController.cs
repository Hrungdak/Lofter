using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Functionalities.Contracts;
using Functionalities.Enums;
using Lofter.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lofter.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherForecastDomainService _weatherForecastDomainService;

        public WeatherController(IWeatherForecastDomainService weatherForecastDomainService)
        {
            _weatherForecastDomainService = weatherForecastDomainService;
        }

        public IActionResult Index()
        {
            List<string> weather = _weatherForecastDomainService.GetForecast(80339, DateTime.Now, TemperatureTypeEnum.Celsius, ForecastTypeEnum.fourteenDays);
            return View(new WeatherViewData { WeatherData = weather, Title = "WeatherData", UserName = "TA" });
        }

        public IActionResult GetForecast()
        {
            //return Content("GetForecast Method");

            //ToDo: create IWeatherProvider == my Weathercast, create Weatherforecast (Iweatherprovider), call GetWeather
            return View();
        }
    }
}