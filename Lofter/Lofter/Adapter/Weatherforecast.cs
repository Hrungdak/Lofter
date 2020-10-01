using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lofter.Contracts;

namespace Lofter.Adapter
{
    public class Weatherforecast
    {
        private IWeatherProvider _weatherProvider;

        public Weatherforecast(IWeatherProvider weatherProvider)
        {
            _weatherProvider = weatherProvider;
        }

        public List<string> GetWeatherForZipcode(int zipcode)
        {
            List<string> weatherForecast = new List<string>();

            weatherForecast = _weatherProvider.GetWeatherFromProvider(zipcode);
            return weatherForecast;
        }
    }
}