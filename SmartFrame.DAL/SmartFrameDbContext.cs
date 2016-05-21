using SmartFrame.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFrame.DAL
{
    public class SmartFrameDbContext : DbContext
    {
        public SmartFrameDbContext()
            : base("SmartFrameDbContext")
        {

        }
        public DbSet<Image> Images { get; set; }

        public DbSet<Mood> Moods { get; set; }

        public DbSet<PhotoMode> PhotoModes { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<WeatherOnline> WeatherOnline { get; set; }

        public DbSet<WeatherSaved> WeatherSaved { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<User>()
                .HasOptional(u => u.Mood)
                .WithMany(m => m.Users)
                .HasForeignKey(u=>u.MoodId)
                .WillCascadeOnDelete(false);

            builder.Entity<Mood>()
                .HasMany(u => u.Users)
                .WithOptional(m => m.Mood)
                .HasForeignKey(u=>u.MoodId)
                .WillCascadeOnDelete(false);
        }
    }
}
