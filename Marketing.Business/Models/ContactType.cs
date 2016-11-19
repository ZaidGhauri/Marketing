using System.ComponentModel.DataAnnotations;

namespace Marketing.Business.Models
{
    public class ContactType
    {
        public int ContactTypeId { get; set; }

        [StringLength(30)]
        [Display(Name = "Type name")]
        [Required]
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
