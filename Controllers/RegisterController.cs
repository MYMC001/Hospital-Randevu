using Hospital_Randevu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Randevu.Controllers
{
    public class RegisterController : Controller
    {
        private readonly HospitalDbContext _context;

        public RegisterController(HospitalDbContext context)
        {
            _context = context;
        }

        //public IActionResult Doctors()
        //{
        //    var fetch = _context.Doctors.ToList();
        //    return View(fetch);
        //}

        public IActionResult LogUp()
        {
            return View();
        }

        public IActionResult Indexer()
        {
            return View();
        }

        public IActionResult Login()
        {
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
				return View("Indexer");
			}
            ViewBag.err = "Not Found";
            return View();
		}

	}
}
