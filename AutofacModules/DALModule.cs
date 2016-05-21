using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using SmartFrame.DAL;
using SmartFrame.DAL.Interfaces;
using SmartFrame.DAL.Interfaces.Repositories;
using SmartFrame.DAL.Repositories;

namespace AutofacModules
{
    public class DALModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            SmartFrameDbContext dbContext = new SmartFrameDbContext();
            builder.Register(c => new UnitOfWork())
               .As<IUnitOfWork>()
               .InstancePerLifetimeScope();
            builder.Register(c => new ImageRepository(dbContext))
                .As<IImageRepository>()
                .InstancePerLifetimeScope();
            builder.Register(c => new MoodRepository(dbContext))
                .As<IMoodRepository>()
                .InstancePerLifetimeScope();
            builder.Register(c => new PhotoModeRepository(dbContext))
                .As<IPhotoModeRepository>()
                .InstancePerLifetimeScope();
            builder.Register(c => new UserRepository(dbContext))
                .As<IUserRepository>()
                .InstancePerLifetimeScope();
            builder.Register(c => new WeatherOnlineRepository(dbContext))
                .As<IWeatherOnlineRepository>()
                .InstancePerLifetimeScope();
            builder.Register(c => new WeatherSavedRepository(dbContext))
                .As<IWeatherSavedRepository>()
                .InstancePerLifetimeScope();
        }
    }
}
