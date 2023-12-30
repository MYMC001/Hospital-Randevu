using Hospital_Randevu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    }
}
