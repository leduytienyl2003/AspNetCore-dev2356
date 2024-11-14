using Microsoft.AspNetCore.Mvc;

namespace SS01_1.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
