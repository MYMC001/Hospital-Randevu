using System.ComponentModel.DataAnnotations;
using System.Net.Security;

namespace Hospital_Randevu.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Display(Name = " Name ")]
        [Required(ErrorMessage = " Name  required")]
        [StringLength(200)]

        public string UserName { get; set;}
        [Display(Name = " sername ")]
        [Required(ErrorMessage = " sername  required")]
        [StringLength(200)]
		public string Email { get; set; }
		[Display(Name = " Email ")]
		[Required(ErrorMessage = " Email required")]
		[StringLength(200)]

		public string UserSurname { get; set;}
        [Display(Name = "birthday ")]
        [Required(ErrorMessage = " Birth day  required")]
        public DateOnly  BirthDay { get; set; }

        [Display(Name = " Gender ")]
        [Required(ErrorMessage = " Gender  required")]
        public   string Gender { get; set; }

		[Display(Name = "Password ")]
		[Required(ErrorMessage = " Phone  required")]
		public string Password { get; set; }


		[Display(Name = "Phone ")]
        [Required(ErrorMessage = " Phone  required")]
        public   string Phone { get; set; }    

      
    }
}
