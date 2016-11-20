using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Interface;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;
using System.Linq;

namespace Marketing.DataAccess.Repositories
{
    public class ContactUsManagementRepository : WriteRepository<Context>, IContactUsManagementRepository
    {
        public string Submit(ContactUs ContactUs)
        {
            try
            {
                var model = Context.ContactUs.Add(new ContactUs()
                {
                    CountryId = ContactUs.CountryId,
                    FirstName = ContactUs.FirstName,
                    LastName = ContactUs.LastName,
                    Phone = ContactUs.Phone,
                    Email = ContactUs.Email,
                    Comments = ContactUs.Comments,
                    WebSiteId = ContactUs.WebSiteId
                });
                Context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
            return "Thank you for contacting us. your query has been forwarded to out concern department, they will get back to you as soon as possible!";
        }
    }
}
