using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Marketing.Business
{
    public static class ObjectFactory
    {
        private static readonly Lazy<Container> _containerBuilder =
            new Lazy<Container>(() => new Container(), LazyThreadSafetyMode.ExecutionAndPublication);

        public static IContainer Container
        {
            get { return _containerBuilder.Value; }
        }

        public static void Initialize<T>() where T : Registry, new()
        {
            Container.Configure(x =>
            {
                x.AddRegistry<T>();
            });
        }
    }
}
