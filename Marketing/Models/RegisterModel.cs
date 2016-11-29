using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Marketing.Models
{
    public class RegisterModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        public bool IsAdmin { get; set; }

        public string Phone { get; set; }

        public System.DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Gender { get; set; }

        public bool IsNewsLetter { get; set; }

        public string PostCode { get; set; }

        public string State { get; set; }
    }
}
