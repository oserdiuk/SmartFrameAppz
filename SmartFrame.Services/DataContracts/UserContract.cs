using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SmartFrame.Services.DataContracts
{
    [DataContract]
    public class UserContract
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string CityName { get; set; }

        [DataMember]
        public int? PhotoModeId { get; set; }

        [DataMember]
        public int? MoodId { get; set; }

        [DataMember]
        public PhotoModeContract PhotoMode { get; set; }

        [DataMember]
        public MoodContract Mood { get; set; }

        [DataMember]
        public ICollection<ImageContract> Images { get; set; }

        [DataMember]
        public ICollection<WeatherSavedContract> Weather { get; set; }
    }
}
