using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Session19.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }
    }
}
