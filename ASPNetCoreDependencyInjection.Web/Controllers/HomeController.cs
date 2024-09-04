using ASPNetCoreDependencyInjection.Web.Interfaces;
using ASPNetCoreDependencyInjection.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPNetCoreDependencyInjection.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonDateService _singletonDateService;

        // Constructor Seviyesinde Enjeksiyon Ýþlemi
        public HomeController(ISingletonDateService singletonDateService)
        {
            _singletonDateService = singletonDateService;
        }

        public IActionResult Index([FromServices] ISingletonDateService singletonDateService_2) // Method Seviyesinde Enjeksiyon Ýþlemi
        {
            ViewBag.Time_1 = _singletonDateService.GetDateTime.TimeOfDay.ToString();
            ViewBag.Time_2 = singletonDateService_2.GetDateTime.TimeOfDay.ToString();

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
