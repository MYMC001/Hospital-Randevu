using Hospital_Randevu.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Randevu.Controllers
{
    public class PatientController : Controller
    {

        public HospitalDbContext _context;

        public PatientController(HospitalDbContext context)
        {
            _context = context;

        }


        public IActionResult Doctors()
        {
            var fetch = _context.Doctors.ToList();
            return View(fetch);
        }
      

       



       
    }
}
