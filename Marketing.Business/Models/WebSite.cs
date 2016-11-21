using Marketing.Common;
using System.ComponentModel.DataAnnotations;


namespace Marketing.Business.Models
{
    public class WebSite : DomainObject
    {
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
