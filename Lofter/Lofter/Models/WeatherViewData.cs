using Lofter.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lofter.Models
{
    public class WeatherViewData : ITitle
    {
        public List<string> WeatherData { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
    }
}