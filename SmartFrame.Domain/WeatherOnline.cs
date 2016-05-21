using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFrame.Domain
{
    public class WeatherOnline
    {
        public int Id { get; set; }

        public string WindDirectionType { get; set; }

        public int WindSpeed { get; set; }

        public int Temperature { get; set; }

        public int TemperatureFeelsLike { get; set; }

        public int WindGust { get; set; }

        public DateTime DateTime { get; set; }

        public string CityName { get; set; }
    }
}
