using System.ComponentModel.DataAnnotations;

namespace EmptySite.Models
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(20)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}