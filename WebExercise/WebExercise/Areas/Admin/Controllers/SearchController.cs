using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WebExercise.Models;

namespace WebExercise.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class SearchController : Controller
    {
        private readonly DbMarketContext _context;

        public SearchController(DbMarketContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult SearchProduct(string keyword)
        {
            List<Product> list = new List<Product>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                list = _context.Products.AsNoTracking()
                .Include(x => x.Cat)
                .OrderByDescending(x => x.ProductName)
                .Take(10)
                .ToList();
            }
            else
            {
                list = _context.Products.AsNoTracking()
                .Where(x => x.ProductName.Contains(keyword))
                .Include(x => x.Cat)
                .OrderByDescending(x => x.ProductName)
                .Take(10)
                .ToList();
            }
            if (list == null)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            else
            {
                return PartialView("ListProductsSearchPartial", list);
            }
        }
    }
}
