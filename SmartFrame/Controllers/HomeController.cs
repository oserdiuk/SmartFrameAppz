using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using SmartFrame.AuthorizationServiceReference;
using SmartFrame.ImageServiceReference;
using SmartFrame.Models.Images;
using SmartFrame.Models.Weather;
using SmartFrame.WeatherOnlineServiceReference;

namespace SmartFrame.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Mapper.CreateMap<WeatherData, WeatherViewModel>().ReverseMap();
            WeatherViewModel model = new WeatherViewModel();
            using (var client = new WeatherOnlineServiceClient())
            {
                var weather = client.GetWeather("poltava");
                model = Mapper.Map<WeatherViewModel>(weather);
            }

            return View(model);
        }

        public ActionResult GetMyImages()
        {
            Mapper.CreateMap<Services.DataContracts.ImageContract, UserImageViewModel>();

            using (ImageServiceClient client = new ImageServiceClient())
            {
                var images = client.GetMyImages(User.Identity.Name);
                var model = Mapper.Map<UserImageViewModel>(images);
                return View(model);
            }
        }

        public ActionResult UploadImage(HttpPostedFileBase file)
        {
            if (file != null)
            {
                byte[] imageBuffer;
                using (var ms = new MemoryStream())
                {
                    file.InputStream.CopyTo(ms);
                    imageBuffer = ms.GetBuffer();
                }

                using (var client = new ImageServiceClient())
                {
                    client.UploadImage(imageBuffer, 0, User.Identity.Name);
                }
            }

            return RedirectToAction("Index");
        }
    }
}