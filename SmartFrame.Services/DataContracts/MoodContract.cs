using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SmartFrame.Services.DataContracts
{
    [DataContract]
    public class MoodContract
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public List<UserContract> Users { get; set; }

        [DataMember]
        public List<ImageContract> Images { get; set; }
    }
}
