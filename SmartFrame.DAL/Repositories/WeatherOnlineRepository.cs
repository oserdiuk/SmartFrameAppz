using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartFrame.DAL.Interfaces.Repositories;
using SmartFrame.Domain;

namespace SmartFrame.DAL.Repositories
{
    public class WeatherOnlineRepository : RepositoryBase<WeatherOnline>, IWeatherOnlineRepository
    {
        public WeatherOnlineRepository(SmartFrameDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}