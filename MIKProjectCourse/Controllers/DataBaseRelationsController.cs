using Microsoft.AspNetCore.Mvc;

namespace MIKProjectCourse.Controllers
{
    public class DataBaseRelationsController : Controller
    {
        public IActionResult DatabaseRelations() => View();
        public IActionResult OneToOne() => View();
        public IActionResult OneToMany() => View();
        public IActionResult ManyToMany() => View();
        public IActionResult ManyToManyWithJoin() => View();
    }
}
