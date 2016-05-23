using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartFrame.Models.Account
{
    public class LoginViewModel
    {
        [DisplayName("Enter your device's name")]
        public string  UserName { get; set; }

        [DisplayName("Enter your password")]
        public string Password { get; set; }
    }
}