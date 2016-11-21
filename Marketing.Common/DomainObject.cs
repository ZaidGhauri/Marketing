using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marketing.Common
{
    public class DomainObject
    {
        public DomainObject()
        {
            Created = DateTimeHelper.Now();
            Modified = DateTimeHelper.Now();
            IsActive = true;
        }
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
