using System.ComponentModel.DataAnnotations;

namespace Hospital_Randevu
{
    public class DoctorPreview
    {

        public int DoctorID { get; set; }

        
        public string? FullName { get; set; }

       
        public string? specialty { get; set; }

       
        public string? Office { get; set; }

        
        public int age { get; set; }

        public string? PhoneNumber { get; set; }
        public IFormFile Photo { get; set; }
    }
}
