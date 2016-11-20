using Marketing.Common;
using System.ComponentModel.DataAnnotations;


namespace Marketing.Business.Models
{
   public class Tag : DomainObject
   {
       [StringLength(50)]
       [Display(Name = "Name")]
       public string Name { get; set; }
       public string Description { get; set; }
       public string Meta { get; set; }
   }
}
