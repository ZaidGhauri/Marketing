
using Marketing.Common;
namespace Marketing.Data
{
    public class Tag : DomainObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Meta { get; set; }
    }
}
