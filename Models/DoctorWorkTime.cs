using System.ComponentModel.DataAnnotations;

namespace Hospital_Randevu.Models
{
    public class DoctorWorkTime
    {

        [Key]
        public  int DoctorWorkTimeID {  get; set; }

        [Display(Name = "Workhours")]
        [Required(ErrorMessage = "Doctor Workhours  required")]
        public TimeSpan StartHour { get; set; }
        [Display(Name = "Workhours")]
        [Required(ErrorMessage = "Doctor Workhours  required")]
        public TimeSpan EndHour{ get; set; }
       
        [Display(Name = "WorkDaysFrom")]
        [Required(ErrorMessage = "Doctor WorkDays  required")]
        public string? WorkDaysFrom { get; set; }

        [Display(Name = "WorkDaysFrom")]
        [Required(ErrorMessage = "Doctor WorkDays  required")]
        public string? WorkDaysTo { get; set; }
        public int DoctorID { get; set; }
        public Doctor? Doctor { get; set; }  
    }

}
