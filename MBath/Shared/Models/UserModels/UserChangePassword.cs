using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBath.Shared.Models.UserModels
{
    public class UserChangePassword
    {
        [Required, StringLength(100, MinimumLength =16)]
        public string Password { get; set; } = string.Empty;

        [Compare("Password",ErrorMessage ="Passwords don't match!")]
        public string ConfirmPassword { get; set; }= string.Empty;
    }
}
