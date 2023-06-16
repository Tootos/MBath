using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBath.Shared.Models.UserModels
{
    public class UserRegister
    {
        [Required, EmailAddress]
        public string Email { get; set; }=string.Empty;
        [Required]
        public string Password { get; set; }=string.Empty;
        [Compare("Password",ErrorMessage ="Passwords don't match!")]
        public string ConfirmPassword { get; set; }=string.Empty;

    }
}
