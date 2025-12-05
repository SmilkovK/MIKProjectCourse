using Microsoft.AspNetCore.Mvc;

namespace MIKProjectCourse.Controllers
{
    public class IntroductionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Guide()
        {
            return View();
        }
        public IActionResult TaskGuide()
        {
            return View();
        }
    }
}
