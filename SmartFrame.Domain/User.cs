using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFrame.Domain
{
    public class User
    {
        public virtual City City { get; set; }

        public virtual PhotoMode PhotoMode { get; set; }

        public virtual Mood Mood { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<WeatherSaved> Weather { get; set; }
    }
}
