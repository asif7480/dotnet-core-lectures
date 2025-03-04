using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace RoleBaseAuthAndCrud.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string Gender { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
