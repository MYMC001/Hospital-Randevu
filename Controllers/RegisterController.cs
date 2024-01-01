using Hospital_Randevu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Randevu.Controllers
{
    public class RegisterController : Controller
    {
        private readonly HospitalDbContext _context;
        private readonly IStringLocalizer<DoctorController> _localizer;
        public RegisterController(HospitalDbContext context    , IStringLocalizer<DoctorController> localizer)
        {
            _context = context;
            _localizer = localizer;
        }

        //public IActionResult Doctors()
        //{
        //    var fetch = _context.Doctors.ToList();
        //    return View(fetch);
        //}

        public IActionResult LogUp()
        {

            ViewData["Name"] = _localizer["Name"];
            ViewData["UserName"] = _localizer["UserName"];
			ViewData["Birth day"] = _localizer["Birth day"];
			ViewData["Phone"] = _localizer["Phone"];
			ViewData["Email"] = _localizer["Email"];
			ViewData["Password"] = _localizer["Password"];
			ViewData["Gender"] = _localizer["Gender"];
			ViewData["Forward"] = _localizer["Forward"];




			return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
			ViewData["Password"] = _localizer["Password"];
			ViewData["Email"] = _localizer["Email"];
			ViewData["Login"] = _localizer["Login"];
			ViewData["SignUp"] = _localizer["SignUp"];
			return View();
        }

        [HttpPost]
        public IActionResult LogUp(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            ModelState.Clear();
            return View();
        }

        [HttpPost]
		public IActionResult Login(User user)
		{
			var check = _context.Users.Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();
			if (check != null)
			{

				HttpContext.Session.SetString("Username", check.UserName);
				var name = HttpContext.Session.GetString("Username");
				ViewBag.Username = name;
				return View("Index");
			}

          
            ViewBag.err = "Not Found";
            return View();
		}

	}
}
