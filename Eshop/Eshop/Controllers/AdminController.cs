using Eshop.Models.DbModels;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Eshop.Controllers
{
    public class AdminController : Controller
    {

        private readonly _DbContext _dbContext;
        public AdminController(_DbContext _dbContext)
        {
            _dbContext = _dbContext;
        }

		public IActionResult Dashboard()
		{
			return View("Dashboard");
		}


}







