using Hospital_Randevu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Hospital_Randevu.Controllers
{
    public class ReservationController : Controller
    {
        public HospitalDbContext _context;

        public ReservationController(HospitalDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddReservation()
        {
            ViewBag.Getdoc = _context.Doctors.ToList();
            ViewBag.Getpatient = _context.Users.ToList();
            //var getdoctor = _context.Reservations.Include(x => x.Doctor).ToList();
            return View();
        }


        public IActionResult RemoveReservation(int id)
        {
            var delete = _context.Reservations.FirstOrDefault(x => x.reservationID == id);


            return View();
        }

        public IActionResult TableReservation()
        {

            var Getdoc = _context.Reservations.Include(x => x.Doctor).ToList();
         
            return View(Getdoc);
        }
        public IActionResult RemoReservation(int id)
        {
            var delete = _context.Reservations.FirstOrDefault(x => x.reservationID == id);


            return View();
        }

        [HttpPost]

        public async Task<IActionResult> AddReservation(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();
            ModelState.Clear();

            return RedirectToAction(nameof(AddReservation));
        }

        [HttpPost]

        public async Task<IActionResult> RemoveReservation(Reservation reservation)
        {

            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
            ModelState.Clear();

            return RedirectToAction(nameof(RemoveReservation));
        }

        [HttpPost]

        public async Task<IActionResult> UpdateReservation(Reservation reservation)
        {

            _context.Reservations.Update(reservation);
            await _context.SaveChangesAsync();
            ModelState.Clear();

            return RedirectToAction(nameof(UpdateReservation));
        }
    }
}
