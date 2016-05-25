using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartFrame.Models.Weather
{
    public class WeatherCompareViewModel
    {
        public List<WeatherViewModel> WeatherOnline { get; set; }

        public List<WeatherViewModel> WeatherSaved { get; set; }
    }
}