using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SmartFrame.Services.DataContracts
{
    [DataContract]
    public class WeatherSavedContract
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string WindDirectionType { get; set; }

        [DataMember]
        public int WindSpeed { get; set; }

        [DataMember]
        public int Temperature { get; set; }

        [DataMember]
        public int TemperatureFeelsLike { get; set; }

        [DataMember]
        public int WindGust { get; set; }

        [DataMember]
        public UserContract User { get; set; }
    }
}
