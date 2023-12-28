using Microsoft.EntityFrameworkCore;

namespace Hospital_Randevu.Models
{
    public class HospitalDbContext:DbContext
    {

        public DbSet<Doctor> Doctors { get; set; }  

        public  HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options) { 
        }  
    }
}
