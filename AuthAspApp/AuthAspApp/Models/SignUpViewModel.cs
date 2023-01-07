﻿using System.ComponentModel.DataAnnotations;

namespace AuthAspApp.Models
{
    public class SignUpViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [Compare("PasswordConfirm")]
        public string Password { get; set; }

        [Required]
        public string PasswordConfirm { get; set; }
    }
}
