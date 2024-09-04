using ASPNetCoreDependencyInjection.Web.Interfaces;
using ASPNetCoreDependencyInjection.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPNetCoreDependencyInjection.Web.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ISingletonDateService _singletonDateService; // Singleton Uygulama Ayakta Olduðu Sürece Bir Defa Oluþturulur.
        //private readonly IScopedDateService _scopedDateService; // Scoped Uygulama Ayakta Olduðu Sürece Her Request Olduðunda Yeniden Oluþturulur.
        private readonly ITransientDateService _transientDateService;

        // Constructor Seviyesinde Enjeksiyon Ýþlemi
        public HomeController(ITransientDateService transientDateService)
        {
            _transientDateService = transientDateService; 
        }

        public IActionResult Index([FromServices] ITransientDateService transientDateService_2) // Method Seviyesinde Enjeksiyon Ýþlemi
        {
            ViewBag.Time_1 = _transientDateService.GetDateTime.TimeOfDay.ToString();
            ViewBag.Time_2 = transientDateService_2.GetDateTime.TimeOfDay.ToString();

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
