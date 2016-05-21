using System.Runtime.Serialization;
using SmartFrame.Domain;

namespace SmartFrame.Services.DataContracts
{
    [DataContract]
    public class WeatherData
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
        public string CityName { get; set; }
    }
}