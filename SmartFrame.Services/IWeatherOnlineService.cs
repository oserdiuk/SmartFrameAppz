﻿using SmartFrame.Services.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SmartFrame.Services
{
    [ServiceContract]
    public interface IWeatherOnlineService
    {
        [OperationContract]
        Task<WeatherData> GetWeather(string city);
    }
}
