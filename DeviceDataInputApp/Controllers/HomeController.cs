using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DeviceDataInputApp.Controllers
{
    public class HomeController : Controller
    {
        public static string DATA;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Get()
        {
            ViewBag.Data = DATA;
            ViewBag.Json = DeviceController.JSON;
            return View("Input");
        }


        [HttpPost]
        public void Input()
        {
            var stream = Request.Body;
            byte[] bt = new byte[1024];
            int length = Request.Body.Read(bt, 0, bt.Length);

            StringBuilder sb = new StringBuilder();
            //for (int i = 3; i < length - 2; i += 2)
            //{
            //    int x = (bt[i] << 8) + bt[i + 1];
            //    sb.Append(x);
            //    sb.Append(',');
            //}
            for (int i = 0; i < length; i++)
            {
                sb.AppendFormat("{0:x2},",bt[i]);
            }

            DATA = sb.ToString();
        }
    }
}