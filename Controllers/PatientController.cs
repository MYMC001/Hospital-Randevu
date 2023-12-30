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

       
        public IActionResult AddPatient()
        {
            return View();
        }


        [HttpPost]

        public async  Task<IActionResult> AddPatient(Patient patient)
        {
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();
            ModelState.Clear();

            return RedirectToAction(nameof(AddPatient));
        }



       
    }
}
