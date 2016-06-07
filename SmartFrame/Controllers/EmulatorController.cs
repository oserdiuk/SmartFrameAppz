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
        public async Task<ActionResult> Index(string keyWord = "all vocabulary")
        {
            var client = ApiClient.GetApiClientWithClientCredentials(apiKey, secret);
            var searchResult = await client.Search()
                .Images()
                .WithPhrase(keyWord)
                .WithSortOrder("best_match")
                .WithPageSize(10)
                .WithPage(new Random().Next(15))
                .ExecuteAsync();

            List<string> result = new List<string>();
            foreach (var image in searchResult.images)
            {
                foreach (var item in image.display_sizes)
                {
                    var r = item.uri;
                    result.Add(r.ToString());
                }
            }

            return View(result);
        }
    }
}