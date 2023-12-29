using Hospital_Randevu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Randevu.Controllers
{
    public class DoctorWorkTimeController : Controller
    {


        public HospitalDbContext _context;
      
        public DoctorWorkTimeController(HospitalDbContext context)
        {
            _context = context;
          
        }
        public  IActionResult AddWork()
        {
           
                ViewBag.getfullname = "This Doctor Added";
            
            ViewBag.getwork=_context.Doctors.ToList();
            return View();
        }
        public IActionResult PrintWork()
        {
            var Getwork = _context.DoctorWorkTimes.Include(x => x.Doctor).ToList();
           
            return View(Getwork);
        }



        



        [HttpPost]

        public async Task<IActionResult> AddWork(DoctorWorkTime dkt)
        {
            _context.DoctorWorkTimes.Add(dkt);
             await _context.SaveChangesAsync(); 
            ModelState.Clear();

            return RedirectToAction(nameof(PrintWork));

        }
    }
}
