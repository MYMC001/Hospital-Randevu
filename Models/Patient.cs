using System.ComponentModel.DataAnnotations;
using System.Net.Security;

namespace Hospital_Randevu.Models
{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }
        [Display(Name = "Patient Name ")]
        [Required(ErrorMessage = "Patient Name  required")]
        [StringLength(200)]

        public string? PatientName { get; set;}
        [Display(Name = "Patient Name ")]
        [Required(ErrorMessage = "Patient sername  required")]
        [StringLength(200)]

        public string? PatientSername { get; set;}
        [Display(Name = "Patient birthday ")]
        [Required(ErrorMessage = "Patient Birth day  required")]
        public DateOnly  BirthDay { get; set; }

        [Display(Name = "Patient Name ")]
        [Required(ErrorMessage = "Patient Gender  required")]

        public   string? Gender { get; set; }
        [Display(Name = "Patient Name ")]
        [Required(ErrorMessage = "Patient Phone  required")]
        public   string? Phone { get; set; }    

        public ICollection<Reservation>? Reservations { get; set; }  
    }
}
