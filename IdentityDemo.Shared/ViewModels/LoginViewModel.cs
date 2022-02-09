using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IdentityDemo.Shared.ViewModels
{
    public class LoginViewModel
    {
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; } = false;
        [Required, StringLength(50), EmailAddress]
        public string Email { get; set; }
        [Required, StringLength(50,MinimumLength = 8)]
        public string Password { get; set; }
    }
}
