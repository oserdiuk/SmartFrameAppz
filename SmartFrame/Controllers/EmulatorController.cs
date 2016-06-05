using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using GettyImages.Api;
using GettyImages.Api.Search.Entity;

namespace SmartFrame.Controllers
{
    public class EmulatorController : Controller
    {
        private readonly string apiKey = "beh4sh3g8s9effzxrhjmxm8f";
        private readonly string secret = "A27r9J6BFxthsfZmGdNudvTefr7sfcSFNN7Z5fQbaTuMk";
        // GET: Emulator
        public  async Task<ActionResult> Index()
        {
            var client = ApiClient.GetApiClientWithClientCredentials(apiKey, secret);
            var searchResult =  await client.Search()
                .Images()
                .Editorial()
                .WithEditorialSegment(EditorialSegment.News)
                .WithPhrase("all vocabulary")
                .WithSortOrder("newest")
                .WithPageSize(10)
                .WithPage(1)
                .ExecuteAsync();
            var r = searchResult.images.ToList();
            return View();
        }
    }
}