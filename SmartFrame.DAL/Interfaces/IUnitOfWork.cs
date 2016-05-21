using SmartFrame.DAL.Interfaces.Repositories;

namespace SmartFrame.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IWeatherOnlineRepository WeatherOnlineRepository { get; }
        IImageRepository ImageRepository { get; }
        IMoodRepository MoodRepository { get; }
        IPhotoModeRepository PhotoModeRepository { get; }
        IUserRepository UserRepository { get; }
        IWeatherSavedRepository WeatherSavedRepository { get; }

        void Save();
    }
}