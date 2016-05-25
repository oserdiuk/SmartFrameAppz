using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using APIXULib;
using AutoMapper;
using SmartFrame.DAL;
using SmartFrame.DAL.Interfaces;
using SmartFrame.Domain;
using SmartFrame.Services.DataContracts;
using SmartFrame.Services.ServiceContracts;

namespace SmartFrame.Services.Services
{
    public class WeatherOnlineService : IWeatherOnlineService
    {
        private string apiUrl = "http://api.apixu.com/v1";
        private IUnitOfWork unitOfWork;

        public WeatherOnlineService()
        {
            this.unitOfWork = new UnitOfWork();

            Mapper.CreateMap<WeatherModel, WeatherData>()
                .ForMember(m => m.CityName, opt => opt.MapFrom(src => src.location.name))
                .ForMember(m => m.Temperature, opt => opt.MapFrom(src => src.current.temp_c))
                .ForMember(m => m.WindGust, opt => opt.MapFrom(src => src.current.wind_degree))
                .ForMember(m => m.WindSpeed, opt => opt.MapFrom(src => src.current.wind_kph))
                .ForMember(m => m.WindDirectionType, opt => opt.MapFrom(src => src.current.wind_dir))
                .ForMember(m => m.TemperatureFeelsLike, opt => opt.MapFrom(src => src.current.feelslike_c));

            Mapper.CreateMap<WeatherData, WeatherOnline>()
               .ForMember(m => m.CityName, opt => opt.MapFrom(src => src.CityName))
               .ForMember(m => m.DateTime, opt => opt.UseValue(DateTime.UtcNow));
        }

        public async Task<WeatherData> GetWeatherForUser(string userName)
        {
            var user = unitOfWork.UserRepository.Get(u => u.UserName == userName).FirstOrDefault();
            if (user == null)
            {
                throw new KeyNotFoundException("User not found with name " + userName);
            }

            return await GetWeather("poltava");
        }

        public async Task<List<WeatherData>> GetSavedWeatherForUser(string userName)
        {
            var user = unitOfWork.UserRepository.Get(u => u.UserName == userName).FirstOrDefault();
            if (user == null)
            {
                throw new KeyNotFoundException("User not found with name " + userName);
            }

            var weather = unitOfWork.WeatherSavedRepository.Get(w => w.User.UserName == userName).ToList();
            return Mapper.Map<List<WeatherData>>(weather);
        }
        
        public async Task<WeatherData> GetWeather(string city)
        {
            var key = "7d92a5b875894f2cb5e173301162105";
            WeatherData weather = await GetWeatherData(key, GetBy.CityName, city, Days.One);
            var weatheronline = Mapper.Map<WeatherOnline>(weather);
            unitOfWork.WeatherOnlineRepository.Create(weatheronline);
            unitOfWork.Save();
            return weather;
        }

        public async Task<WeatherData> GetWeatherData(string key, GetBy getBy, string value, Days forecastOfDays)
        {
            var model = await GetData(apiUrl + RequestBuilder.PrepareRequest(MethodType.Forecast, key, getBy, value, forecastOfDays));
            var data = AutoMapper.Mapper.Map<WeatherData>(model);
            return data;
        }

        private async Task<WeatherModel> GetData(string url)
        {
            string urlParameters = "";
            HttpClient client = new HttpClient { BaseAddress = new Uri(url) };

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response =  client.GetAsync(urlParameters).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                return await response.Content.ReadAsAsync<WeatherModel>();

            }
            else
            {
                return new WeatherModel();
            }
        }
    }

}
