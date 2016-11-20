using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Marketing.Models
{
    public class ContactUsModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        public string Comments { get; set; }
        public int? CountryId { get; set; }
    }
}
