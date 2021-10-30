using Microsoft.AspNetCore.Mvc;

namespace WebExercise.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
