using Hospital_Randevu.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.Extensions.Localization;

namespace Hospital_Randevu.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IStringLocalizer<DoctorController> _localizer;
        public HospitalDbContext _context;
        IWebHostEnvironment hostingenvironment;
        public DoctorController(HospitalDbContext context  , IWebHostEnvironment getphoto, IStringLocalizer<DoctorController> localizer)
        {
            _context = context;
            hostingenvironment = getphoto;
            _localizer = localizer ;
        }
      
        public IActionResult ListDoctors(string search)
        {
         
            return View(_context.Doctors.Where(x => x.specialty.Contains(search) || search == null|| x.FullName.Contains(search)).ToList());
        }

       
        public IActionResult AddDoctor()
        {
            @ViewData["Back to List"] = _localizer["Back to List"];
            return View();
        }

        public IActionResult PrintDoctor()
        {
            ViewData["Contacts"] = _localizer["Contacts"];
            ViewData["specialtys"] = _localizer["specialtys"];
            var fetch = _context.Doctors.ToList();
            return View(fetch);
        }
        public IActionResult EditDoctor(int id)
        {
             
            return View(_context.Doctors.FirstOrDefault(d => d.DoctorID == id));
        }
        public IActionResult TableReservation()
        {



            return View(_context.Reservations.ToList());
        }
        public IActionResult DeleteDoctor(int id)
        {

            return View(_context.Doctors.FirstOrDefault(d => d.DoctorID == id));
        }

        [HttpPost]

        public IActionResult AddDoctor(DoctorPreview doctor)
        {

            string filename = "";

            if(doctor.Photo!=null)
            {
                string UploadFolder = Path.Combine(hostingenvironment.WebRootPath, "images");
                filename = Guid.NewGuid().ToString() + " " + doctor.Photo.FileName;

                string filepath = Path.Combine(UploadFolder, filename);
                doctor.Photo.CopyTo(new FileStream(filepath, FileMode.Create));

            }

            Doctor doctor1 = new Doctor()
            {
                DoctorID = doctor.DoctorID,
                FullName = doctor.FullName,
                specialty = doctor.specialty,
                Section = doctor.Section,
                image = filename,
                age = doctor.age,
                PhoneNumber=doctor.PhoneNumber


            };

            _context.Doctors.Add(doctor1);
            _context.SaveChanges();
            ModelState.Clear();
            return View();
        }

        [HttpPost]
        public IActionResult EditDoctor(Doctor doctor)
        {

          

            _context.Doctors.Update(doctor);
            _context.SaveChanges(); 
           
           

            return RedirectToAction(nameof(ListDoctors));
        }
        [HttpPost]
        public IActionResult DeleteDoctor(Doctor doctor)
        {



            _context.Remove(doctor);
            _context.SaveChanges();



            return RedirectToAction(nameof(ListDoctors));
        }



    }
}
