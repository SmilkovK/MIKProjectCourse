using Microsoft.AspNetCore.Mvc;

namespace MIKProjectCourse.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FristText()
        {
            return View();
        }
    }
}
