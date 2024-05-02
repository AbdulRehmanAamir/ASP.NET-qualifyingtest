using Microsoft.AspNetCore.Mvc;
using Eshop.Models;
using Eshop.Models.DbModels;

namespace Eshop.Controllers
{
    public class ProductController : Controller
    {
        private readonly _DbContext _db;
        public ProductController(_DbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var products = _db.Products.ToList();

            return View("Product",products);
        }

    }
}
