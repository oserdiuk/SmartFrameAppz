using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFrame.Domain
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string Salt{ get; set; }

        public string CityName { get; set; }

        [ForeignKey("PhotoMode")]
        public int? PhotoModeId { get; set; }

        [ForeignKey("Mood")]
        public int? MoodId { get; set; }

        public virtual PhotoMode PhotoMode { get; set; }

        public virtual Mood Mood { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<WeatherSaved> Weather { get; set; }
    }
}
