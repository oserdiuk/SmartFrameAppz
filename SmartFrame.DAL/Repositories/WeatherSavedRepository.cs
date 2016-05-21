using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartFrame.DAL.Interfaces.Repositories;
using SmartFrame.Domain;

namespace SmartFrame.DAL.Repositories
{
    public class WeatherSavedRepository : RepositoryBase<WeatherSaved>,IWeatherSavedRepository
    {
        public WeatherSavedRepository(SmartFrameDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}