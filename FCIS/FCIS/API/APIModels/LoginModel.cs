using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Optimization.Resources;
namespace FCIS.API.APIModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Email address is not valid.")]
        [RegularExpression(@"^[a-zA-Z0-9 @_.-]+$", ErrorMessage = "English only")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(16, ErrorMessage = "8 characters at least and 16 char maximum", MinimumLength = 8)]
        public string Password { get; set; }

    }
}