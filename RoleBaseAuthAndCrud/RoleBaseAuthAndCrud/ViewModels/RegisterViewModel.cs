using System.ComponentModel.DataAnnotations;

namespace RoleBaseAuthAndCrud.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
