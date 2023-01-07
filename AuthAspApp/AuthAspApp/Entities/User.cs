using System;
using Microsoft.AspNetCore.Identity;
using AuthAspApp.Constants;

namespace AuthAspApp.Entities
{
    public class User : IdentityUser
    {
        public DateTime LastSignInDate { get; set; }

        public DateTime SignUpDate { get; set; }

        public UserStatuses Status { get; set; }
    }
}
