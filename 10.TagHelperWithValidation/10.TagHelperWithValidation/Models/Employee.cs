using System.ComponentModel.DataAnnotations;

namespace _10.TagHelperWithValidation.Models
{
    public class Employee
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Email { get; set; }
    }
}
