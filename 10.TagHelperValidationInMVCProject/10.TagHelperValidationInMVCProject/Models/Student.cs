using System.ComponentModel.DataAnnotations;

namespace _10.TagHelperValidationInMVCProject.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name to insert karo")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "yr 3 to 10 k around name insert karo")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(5, 10)]
        public int? Age { get; set; }

        [Required]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[\\W_]).{8,}$", ErrorMessage = "Password must contain atleast 8 characters with 1 capital, 1 small and 1 special symbol")]
        public string Password { get; set; }


        [Required]
        [Compare("Password", ErrorMessage="Both password must be same")]
        [Display(Name = "Repeat Password")]
        public string ConfirmPassword { get; set; }


        [Required]
        [RegularExpression("^(?:\\+92|92|0)?3\\d{2}\\d{7}$", ErrorMessage = "Insert valid contact number")]
        public string Contact {  get; set; }


    }
}
