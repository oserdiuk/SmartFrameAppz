using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using SmartFrameService.DataContracts;

namespace SmartFrameService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWeatherService" in both code and config file together.
    [ServiceContract]
    public interface IWeatherOnlineService
    {
        [OperationContract]
        Task<WeatherData> GetWeather(DateTime date);
    }
}
