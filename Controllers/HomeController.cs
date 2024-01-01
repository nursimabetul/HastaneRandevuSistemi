using Microsoft.AspNetCore.Mvc;
using HastaneRandevuSistemi.Models;
using System.Diagnostics;
using Newtonsoft.Json;

namespace HastaneRandevuSistemi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        Uri apiAdress = new Uri("https://localhost:7080/anaBilimDali/GetAnaBilimDali");
        private readonly HttpClient _httpClient;     
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = apiAdress;
        }



        public IActionResult Index()
        {
            List<AnaBilimDali> anadallist = new List<AnaBilimDali>();
            HttpResponseMessage response = _httpClient.GetAsync(apiAdress).Result;
            if (response != null)
            {

                string data= response.Content.ReadAsStringAsync().Result;
                anadallist= JsonConvert.DeserializeObject<List<AnaBilimDali>>(data);
            }

            return View(anadallist);
        }
        public IActionResult AnaBilimDali()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}