using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartFrame.WeatherOnlineServiceReference;

namespace SmartFrame.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var client = new WeatherOnlineServiceClient())
            {
                var weather = client.GetWeather("poltava");
            }
            return View();
        
        }
    }
}