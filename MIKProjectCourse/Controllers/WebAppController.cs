using Microsoft.AspNetCore.Mvc;

namespace MIKProjectCourse.Controllers
{
    public class WebAppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BuldingSteps()
        {
            return View();
        }
        public IActionResult Summary()
        {
            return View();
        }
    }
}
