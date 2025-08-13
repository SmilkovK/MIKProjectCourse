using Microsoft.AspNetCore.Mvc;

namespace MIKProjectCourse.Controllers
{
    public class IntroductionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
