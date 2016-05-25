using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartFrame.Models.Weather
{
    public class WeatherViewModel
    {
        public int Id { get; set; }

        public string WindDirectionType { get; set; }

        public int WindSpeed { get; set; }

        public int Temperature { get; set; }

        public int TemperatureFeelsLike { get; set; }

        public int WindGust { get; set; }
    }
}