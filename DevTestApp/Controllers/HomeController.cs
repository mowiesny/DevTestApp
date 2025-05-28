using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Management;
using DevTestApp.Models;

namespace DevTestApp.Controllers
{
    public class HomeController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<ActionResult> Index()
        {
            string apiUrl = "https://swapi.info/api/films";
            List<Film> films = new List<Film>();
            ViewBag.Message = WebFormat("Movies Page");
            try
            {
                var response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    List<Film> Films = JsonConvert.DeserializeObject<List<Film>>(json);
                    var apiResponse = Films;
                    films = Films.OrderBy(o => o.EpisodeId).ToList();

                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error fetching data: " + ex.Message;
            }

            return View(films);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}