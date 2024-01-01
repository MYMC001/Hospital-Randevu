using System.ComponentModel.DataAnnotations;

namespace Hospital_Randevu.Models
{
    public class Doctor
    {

        [Key]

        
        public int DoctorID { get; set; }

        [Display(Name = "FullName")]
        [StringLength(100)]
        [Required(ErrorMessage = "Doctor FullName required")]
        public string? FullName { get; set; }

        [Display(Name = "specialty")]
        [Required  (ErrorMessage = "specialty required")]
        [StringLength(100)]
        public string? specialty { get; set; }

        [Display(Name = "Section")]
        [Required(ErrorMessage = "Doctor Section  required")]
        [StringLength(200)]
        public string? Section { get; set; }


        [Display(Name = "image")]
        [Required(ErrorMessage = "Doctor Image  required")]
        public string image {  get; set; }


        [Display(Name = "Age")]
        [Required(ErrorMessage = "Doctor Age  required")]
        public int age { get; set; }


        [Display(Name = "PhoneNumber")]
        [Required(ErrorMessage = "Doctor PhoneNumber  required")]
        public string? PhoneNumber { get; set; }

       

      public ICollection<Reservation>   Reservations { get; set; }



    }
}
