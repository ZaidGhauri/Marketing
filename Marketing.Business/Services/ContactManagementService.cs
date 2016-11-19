using AutoMapper;
using Marketing.Business.Interface;
using Marketing.Business.Models;
using Marketing.Common;
using Marketing.DataAccess.Interface;
using StructureMap;
using System.Collections.Generic;
using System.Linq;

namespace Marketing.Business.Services
{
    public class ContactManagementService : IContactManagementService
    {
        private readonly IContactManagementRepository _contactManagementRepository;
        public ContactManagementService()
        {
            var container = new Container(_ =>
            {
                _.For<IContactManagementService>().Use<ContactManagementService>();
            });
            _contactManagementRepository = container.GetInstance<IContactManagementRepository>();
           
        }
        public IEnumerable<ContactType> GetContactTypes(ICriteria criteria)
        {
            return
                 _contactManagementRepository.GetContactTypes(criteria)
                                             .Select(Mapper.Map<Data.ContactType, ContactType>);
        }
        public void Dispose()
        {
            _contactManagementRepository.Dispose();
        }

        public IEnumerable<ContactType> GetAllContactTypes()
        {
            return
                _contactManagementRepository.GetAllContactTypes().Select(Mapper.Map<Data.ContactType, ContactType>);
        }

        public int GetTotalContactTypes()
        {
            return _contactManagementRepository.GetTotalContactTypes();
        }
    }
}