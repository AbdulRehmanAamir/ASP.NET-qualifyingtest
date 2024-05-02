using Eshop.Models.DbModels;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly _DbContext _dbContext;

        public AuthenticationController(_DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View("Login");
        }

		[HttpPost]
		public IActionResult Login(Users model)
		{
			if (IsAdmin(model.Email, model.Password))
			{
				return RedirectToAction("Dashboard", "Admin");
			}
			else
			{
				if (!string.IsNullOrEmpty(model.Email) && !string.IsNullOrEmpty(model.Password))
				{
					var user = _dbContext.User.FirstOrDefault(x => x.Email == model.Email);

					if (user != null)
					{
						if (model.Password == user.Password)
						{
							return RedirectToAction("Index", "Home");
						}
						else
						{
							// Invalid Password
							ViewBag.ErrorMessage = "Invalid password";
							return View("Login", model);
						}
					}
					else
					{
						// User not found
						ViewBag.ErrorMessage = "User not found";
						return View("Login", model);
					}
				}
				else
				{
					// Email or Password is required
					ViewBag.ErrorMessage = "Email and password are required";
					return View("Login", model);
				}
			}
		}

		private bool IsAdmin(string email, string password)
		{
			
			return email == "admin@eshop.com" && password == "123123123";
		}

		public IActionResult Registeration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterUser(Users model)
        {
            if (model.Email != null && model.Password != null && model.FirstName != null && model.LastName !=null && model.Dob != null && model.Address != null && model.PhoneNumber != null)
            {
                var userexists = _dbContext.User.Where(x=>x.Email ==  model.Email).FirstOrDefault();
                if (userexists != null)
                {
                    ViewBag.ErrorMessage = "Email already Exists";
                    return View("Registeration", model);

                }
                else
                {
                    Users obj = new Users ();
                    obj.Email = model.Email;
                    obj.Password = model.Password;
                    obj.FirstName = model.FirstName;
                    obj.LastName = model.LastName;
                    obj.Dob = model.Dob;
                    obj.Address = model.Address;
                    obj.PhoneNumber = model.PhoneNumber;
                    obj.RoleId = 2;

                    _dbContext.User.Add(obj);
                    _dbContext.SaveChanges();
                    return RedirectToAction("Index", "Home");

                }
            }
            else
            {
                //Required All Fields
                ViewBag.ErrorMessage = "Required Fields";
                return View("Registeration", model);
            }
        }
    }
}
