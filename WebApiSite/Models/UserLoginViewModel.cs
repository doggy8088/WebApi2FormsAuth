using System.ComponentModel.DataAnnotations;

namespace WebApiSite.Models
{
    public class UserLoginViewModel
    {
        [Required]
        [StringLength(20)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}