using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Randevu.Models
{
    public class HospitalDbContext:DbContext
    {

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<DoctorWorkTime> DoctorWorkTimes { get; set; }

        public DbSet<Reservation> Reservations { get; set; }


        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options) { 
        }  
    }
}
