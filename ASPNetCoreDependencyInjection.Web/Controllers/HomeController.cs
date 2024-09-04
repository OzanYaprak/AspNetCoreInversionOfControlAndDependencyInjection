using ASPNetCoreDependencyInjection.Web.Interfaces;
using ASPNetCoreDependencyInjection.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPNetCoreDependencyInjection.Web.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ISingletonDateService _singletonDateService; // Singleton Uygulama Ayakta Oldu�u S�rece Bir Defa Olu�turulur.
        private readonly IScopedDateService _scopedDateService; // Scoped Uygulama Ayakta Oldu�u S�rece Her Request Oldu�unda Yeniden Olu�turulur.

        // Constructor Seviyesinde Enjeksiyon ��lemi
        public HomeController(IScopedDateService scopedDateService)
        {
            _scopedDateService = scopedDateService; 
        }

        public IActionResult Index([FromServices] IScopedDateService scopedDateService_2) // Method Seviyesinde Enjeksiyon ��lemi
        {
            ViewBag.Time_1 = _scopedDateService.GetDateTime.TimeOfDay.ToString();
            ViewBag.Time_2 = scopedDateService_2.GetDateTime.TimeOfDay.ToString();

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
