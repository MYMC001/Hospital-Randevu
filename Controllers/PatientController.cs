using Hospital_Randevu.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Localization;

namespace Hospital_Randevu.Controllers
{
    public class PatientController : Controller
    {

        public HospitalDbContext _context;

        private readonly IStringLocalizer<DoctorController> _localizer;
        public PatientController(HospitalDbContext context, IStringLocalizer<DoctorController> localizer)
        {
            _context = context;
            _localizer = localizer;
        }
        public IActionResult Doctors()
        {

           
          
            ViewData["Contact"] = _localizer["Contact"];
            ViewData["specialty"] = _localizer["specialty"];

            var fetch = _context.Doctors.ToList();
            return View(fetch);
        }
      

       



       
    }
}
