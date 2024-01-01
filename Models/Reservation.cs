using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace Hospital_Randevu.Models
{
    public class Reservation
    {



        public int reservationID { get; set; }
        [Display(Name = "PatientID ")]
        [Required(ErrorMessage = "PatientID required")]
        public int UserID { get; set; }

        [Display(Name = "DoctorID ")]
        [Required(ErrorMessage = "DoctorID required")]
        public int DoctorID { get; set; }

        [Display(Name = "ReservationSaat ")]
        [Required(ErrorMessage = "saat required")]
        public TimeSpan ReservationSaat { get; set; }

        [Display(Name = "ReservationDay ")]
        [Required(ErrorMessage = "Day required")]
        public string ReservationDay { get; set; }


         public Doctor Doctor { get; set; }

        public  User User { get; set; }



    }
}