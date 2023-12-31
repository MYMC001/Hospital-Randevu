using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace Hospital_Randevu.Models
{
    public class Reservation
    {


        
        public int reservationID { get; set; }
        [Display(Name = "PatientID ")]
        [Required(ErrorMessage = "PatientID required")]
        public int PatientID { get; set; }

        [Display(Name = "DoctorID ")]
        [Required(ErrorMessage = "DoctorID required")]
        public int DoctorID { get; set; }

        [Display(Name = "ReservationDate ")]
        [Required(ErrorMessage = "ReservationDate required")]
        public DateTime ReservationDate { get; set; }


       
    }
}
