using System.ComponentModel.DataAnnotations;

namespace AuthAspApp.Models
{
    public class SignInViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
