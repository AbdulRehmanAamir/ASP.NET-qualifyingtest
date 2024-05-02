using Eshop.Models;
using Eshop.Models.DbModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Eshop.Controllers
{
    public class HomeController : Controller
    {
		private readonly _DbContext _db;
		public HomeController(_DbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			var _genderCategories = _db.ProductGenders.ToList();

            foreach (var gender in _genderCategories)
            {
				var _categories = _db.ProductCategory.Where(x => x.ProductGenderId == gender.Id).ToList();


                
            }


			LayoutViewModel obj = new LayoutViewModel()
			{
				data = _genderCategories,
			};
			ViewBag.myModel = obj;
			return View();
		}

		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
