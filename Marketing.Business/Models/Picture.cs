using Marketing.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Marketing.Business.Models
{
   public class Picture : DomainObject
    {
        public string Name { get; set; }
        public string Url { get; set; }   
   
   }
}
