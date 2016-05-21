using System;
using APIXULib;
using AutoMapper;
using SmartFrame.Domain;
using SmartFrame.Services.DataContracts;

namespace SmartFrame.Services.MapperProfiles
{
    class WeatherProfile : Profile
    {
        public WeatherProfile()
        {
            CreateMap<WeatherModel, WeatherData>()
                .ForMember(m => m.CityName, opt => opt.MapFrom(src => src.location.name))
                .ForMember(m => m.Temperature, opt => opt.MapFrom(src => src.current.temp_c))
                .ForMember(m => m.WindGust, opt => opt.MapFrom(src => src.current.wind_degree))
                .ForMember(m => m.WindSpeed, opt => opt.MapFrom(src => src.current.wind_kph))
                .ForMember(m => m.WindDirectionType, opt => opt.MapFrom(src => src.current.wind_dir))
                .ForMember(m => m.TemperatureFeelsLike, opt => opt.MapFrom(src => src.current.feelslike_c));

            CreateMap<WeatherData, WeatherOnline>()
               .ForMember(m => m.CityName, opt => opt.MapFrom(src => src.CityName))
               .ForMember(m => m.DateTime, opt => opt.UseValue(DateTime.UtcNow));
            
        }
    }
}
