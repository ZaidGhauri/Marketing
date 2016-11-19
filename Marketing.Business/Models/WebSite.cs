using System.ComponentModel.DataAnnotations;


namespace Marketing.Business.Models
{
    public class WebSite
    {
        public int WebId { get; set; }

        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public string IsActive { get; set; }

        public string Url { get; set; }
    }
}
