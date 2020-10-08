using Lofter.Contracts;
using System.Collections.Generic;

namespace Lofter.Models
{
    public class WeatherViewData : ITitle
    {
        public List<string> WeatherData { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
    }
}