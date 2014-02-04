using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;
using WhatsNew_Mobile.Models;

namespace WhatsNew_Mobile.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var client = new HttpClient();
            var response = client.GetAsync(Url.Action("Gallery", "MobilePhoto", null, Request.Url.Scheme)).Result;
            var value = response.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<List<MobPhoto>>(value);

            return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
