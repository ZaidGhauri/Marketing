using Marketing.Common;
using System;
using System.Collections.Generic;
namespace Marketing.Data
{
    public class Country : DomainObject
    {
        public string Name { get; set; }
        public string TwoLetterIsoCode { get; set; }
        public string ThreeLetterIsoCode { get; set; }
        public string NumericIsoCode { get; set; }
        public string DisplayOrder { get; set; }
        public bool Published { get; set; }
        public bool LimitedToStores { get; set; }
    }
}
