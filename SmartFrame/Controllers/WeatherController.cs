using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using SmartFrame.Models.Weather;
using SmartFrame.WeatherOnlineServiceReference;

namespace SmartFrame.Controllers
{
    public class WeatherController : Controller
    {
        public WeatherController()
        {
            Mapper.CreateMap<WeatherData, WeatherViewModel>().ReverseMap();
        }

        public ActionResult Get()
        {
            WeatherViewModel model = new WeatherViewModel();
            using (var client = new WeatherOnlineServiceClient())
            {
                var weather = client.GetWeatherForUser(User.Identity.Name);
                model = Mapper.Map<WeatherViewModel>(weather);
            }

            return View(model);
        }

        public ActionResult Compare()
        {
            WeatherCompareViewModel model = new WeatherCompareViewModel();
            using (var client = new WeatherOnlineServiceClient())
            {
                var weather = client.GetWeatherForUser(User.Identity.Name);
                model.WeatherOnline = Mapper.Map<WeatherViewModel>(weather);

                var savedWeather = client.GetSavedWeatherForUser(User.Identity.Name);
                model.WeatherSaved = Mapper.Map<WeatherViewModel>(savedWeather);
            }

            return View(model);
        }
    }
}