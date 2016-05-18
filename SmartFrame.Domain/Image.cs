using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFrame.Domain
{
    public class Image
    {
        public virtual User Owner { get; set; }
        public virtual Mood Mood { get; set; }
    }
}
