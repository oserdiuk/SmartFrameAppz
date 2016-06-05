using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartFrame.Models.Weather
{
    public class WeatherCompareViewModel
    {
        public WeatherViewModel WeatherOnline { get; set; }

        public WeatherViewModel WeatherSaved { get; set; }
    }
}