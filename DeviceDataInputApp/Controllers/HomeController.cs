using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DeviceDataInputApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Input()
        {
            var stream = Request.Body;
            byte[] bt = new byte[1024];
            int length = Request.Body.Read(bt, 0, bt.Length);

            StringBuilder sb = new StringBuilder();
            for (int i = 3; i < length - 2; i += 2)
            {
                int x = (bt[i] << 8) + bt[i + 1];
                sb.Append(x);
                sb.Append(',');
            }
            ViewBag.Str = sb.ToString();
            return View();
        }
    }
}