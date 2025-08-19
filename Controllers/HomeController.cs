using Microsoft.AspNetCore.Mvc;

namespace AspNetSampleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
