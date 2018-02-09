using Microsoft.AspNetCore.Mvc;

namespace DeviceDataInputApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}