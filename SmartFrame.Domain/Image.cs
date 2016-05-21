using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFrame.Domain
{
    public class Image
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual int OwnerId { get; set; }

        public virtual int MoodId { get; set; }

        public virtual User Owner { get; set; }
        public virtual Mood Mood { get; set; }
    }
}
