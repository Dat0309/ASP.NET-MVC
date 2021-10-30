using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using WebExercise.Models;

namespace WebExercise.Controllers
{
    public class ProductController : Controller
    {
        private readonly DbMarketContext _context;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            var product = _context.Products.Include(x => x.Cat).FirstOrDefaultAsync(x => x.ProductId == id);
            if(product == null)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}
