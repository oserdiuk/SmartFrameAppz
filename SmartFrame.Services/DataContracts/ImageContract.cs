using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SmartFrame.Services.DataContracts
{
    [DataContract]
    public class ImageContract
    {
        [DataMember]
        public byte[] ImageBytes { get; set; }

        [DataMember]
        public string ImageName { get; set; }

        [DataMember]
        public UserContract Owner { get; set; }
    }
}
