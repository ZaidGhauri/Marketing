using Marketing.Business.Interface;
using Marketing.Business.Models;
using Marketing.Business.Services;
using Marketing.DataAccess.Interface;
using Marketing.DataAccess.Repositories;
using StructureMap;

namespace Marketing.Business.Mappings
{
    public static class ModelMapper
    {
        public static void CreateMaps()
        {
            AutoMapper.Mapper.CreateMap<Data.Category, Category>();
            AutoMapper.Mapper.CreateMap<Data.Store, Store>();

            AutoMapper.Mapper.CreateMap<Data.WebSite, WebSite>();
            AutoMapper.Mapper.CreateMap<WebSite, Data.WebSite>();

            AutoMapper.Mapper.CreateMap<Category, Data.Category>().ForMember(_ => _.Description, _ => _.Ignore());

            //AutoMapper.Mapper.CreateMap<Data.Category, Category>();
            //AutoMapper.Mapper.CreateMap<Category, Data.Category>()
            //    .ForMember(_ => _.Categories, _ => _.Ignore())
            //    .ForMember(_ => _.Stores, _ => _.Ignore());

        }

        public static void CreateServiceMaps()
        {
            var container = new Container(_ =>
            {
                _.For<IModelManagementRepository>().Use<ModelManagementRepository>();
                _.For<IModelManagementService>().Use<ModelManagementService>();
            });
        }

        public static void Verify()
        {
#if DEBUG
            AutoMapper.Mapper.AssertConfigurationIsValid();
#endif
        }

    }
}
