using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFrame.Domain
{
    public class Mood
    {
        public virtual ICollection<User> Users{ get; set; }
        public virtual ICollection<Image> Images{ get; set; }
    }
}
