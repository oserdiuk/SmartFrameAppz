using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SmartFrame.Services.DataContracts
{
    [DataContract]
    public class ImageDataContract
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int OwnerId { get; set; }

        [DataMember]
        public int MoodId { get; set; }

        [DataMember]
        public UserContract Owner { get; set; }

        [DataMember]
        public MoodContract Mood { get; set; }
    }
}
