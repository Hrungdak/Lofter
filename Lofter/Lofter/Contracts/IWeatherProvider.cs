using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lofter.Contracts
{
    public interface IWeatherProvider
    {
        public List<string> GetWeatherFromProvider(int zipcode);
    }
}