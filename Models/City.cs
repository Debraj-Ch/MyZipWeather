using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyZipWeather.Models
{
    public class City
    {
        public string PinCode { get; set; }

        [DisplayName("City")]
        public string CityName { get; set; }
        [DisplayName("Max Temperature(Celcius)")]
        public string HighestTemp { get; set; }
    }
}
