using System;
using System.Data.Entity;
using SmartFrame.DAL.Interfaces;
using SmartFrame.DAL.Interfaces.Repositories;
using SmartFrame.DAL.Repositories;
using SmartFrame.Domain;

namespace SmartFrame.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SmartFrameDbContext smartFrameDbContext = new SmartFrameDbContext();

        private IWeatherOnlineRepository weatherOnlineRepository;
        private IImageRepository imageRepository;
        private IMoodRepository moodRepository;
        private IPhotoModeRepository photoModeRepository;
        private IUserRepository userRepository;
        private IWeatherSavedRepository weatherSavedRepository;

        public IImageRepository ImageRepository
        {
            get
            {
                if (imageRepository == null)
                {
                    imageRepository = new ImageRepository(smartFrameDbContext);
                }

                return imageRepository;
            }
        }

        public IMoodRepository MoodRepository
        {
            get
            {
                if (moodRepository == null)
                {
                    moodRepository = new MoodRepository(smartFrameDbContext);
                }

                return moodRepository;
            }
        }

        public IPhotoModeRepository PhotoModeRepository
        {
            get
            {
                if (photoModeRepository == null)
                {
                    photoModeRepository = new PhotoModeRepository(smartFrameDbContext);
                }

                return photoModeRepository;
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(smartFrameDbContext);
                }

                return userRepository;
            }
        }

        public IWeatherOnlineRepository WeatherOnlineRepository
        {
            get
            {
                if (weatherOnlineRepository == null)
                {
                    weatherOnlineRepository = new WeatherOnlineRepository(smartFrameDbContext);
                }

                return weatherOnlineRepository;
            }
        }

        public IWeatherSavedRepository WeatherSavedRepository
        {
            get
            {
                if (weatherSavedRepository == null)
                {
                    weatherSavedRepository = new WeatherSavedRepository(smartFrameDbContext);
                }

                return weatherSavedRepository;
            }
        }

        public void Save()
        {
            smartFrameDbContext.SaveChanges();
        }
    }
}