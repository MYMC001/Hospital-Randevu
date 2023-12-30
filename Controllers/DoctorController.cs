using Hospital_Randevu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;

namespace Hospital_Randevu.Controllers
{
    public class DoctorController : Controller
    {
        public HospitalDbContext _context;
        IWebHostEnvironment hostingenvironment;
        public DoctorController(HospitalDbContext context  , IWebHostEnvironment getphoto)
        {
            _context = context;
            hostingenvironment = getphoto;
        }

        public IActionResult ListDoctors(string search)
        {
         
            return View(_context.Doctors.Where(x => x.specialty.Contains(search) || search == null|| x.FullName.Contains(search)).ToList());
        }

       
        public IActionResult AddDoctor()
        {
            return View();
        }

        public IActionResult PrintDoctor()
        {
            var fetch = _context.Doctors.ToList();
            return View(fetch);
        }
        public IActionResult EditDoctor(int id)
        {
             
            return View(_context.Doctors.FirstOrDefault(d => d.DoctorID == id));
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
