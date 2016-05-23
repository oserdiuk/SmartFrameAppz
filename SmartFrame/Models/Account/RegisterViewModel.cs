using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartFrame.Models.Account
{
    public class RegisterViewModel
    {
        [DisplayName("Enter your device's name")]
        [Required]
        public string UserName { get; set; }

        [DisplayName("Enter your password")]
        [Required]
        public string Password { get; set; }

        [DisplayName("Confirm password")]
        [Compare("Password", ErrorMessage = "Passwords are not equal.")]
        [Required]
        public string ConfirmPassword { get; set; }

        [DisplayName("Email")]
        [Required]
        public string Email { get; set; }

        [DisplayName("Enter your city")]
        [Required]
        public string CityName { get; set; }
    }
}