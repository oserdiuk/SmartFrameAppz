using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using SmartFrame.Services.DataContracts;

namespace SmartFrame.Services.ServiceContracts
{
    [ServiceContract]
    public interface IWeatherOnlineService
    {
        [OperationContract]
        Task<WeatherData> GetWeather(string city);

        [OperationContract]
        Task<WeatherData> GetWeatherForUser(string userName);

        [OperationContract]
        Task<List<WeatherData>> GetSavedWeatherForUser(string userName);
    }
}
