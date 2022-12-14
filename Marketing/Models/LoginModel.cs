using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Marketing.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "Remember on this computer")]
        public bool RememberMe { get; set; }
    }
}
