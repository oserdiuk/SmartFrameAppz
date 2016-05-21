using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using SmartFrame.Domain;

namespace SmartFrameService.DataContracts
{
    [DataContract]
    public class WeatherData
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int CityIdFromSite { get; set; }

        [DataMember]
        public PrecipitationType PrecipitationType { get; set; }

        [DataMember]
        public WindDirectionType WindDirectionType { get; set; }

        [DataMember]
        public int WindLowSpeed { get; set; }

        [DataMember]
        public int WindHighSpeed { get; set; }

        [DataMember]
        public int TemperatureLow { get; set; }

        [DataMember]
        public int TemperatureHigh { get; set; }

        [DataMember]
        public int TemperatureFeelsLike { get; set; }

        [DataMember]
        public int WindGust { get; set; }

        [DataMember]
        public City City { get; set; }
    }
}