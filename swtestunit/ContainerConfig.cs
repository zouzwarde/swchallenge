using Autofac;
using swlibrary;
using swlibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swtestunit
{
    public static class ContainerConfig
    {
        public static Autofac.IContainer Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<calculations>().As<Icalculations>();
            builder.RegisterType<datafromapi>().As<Idatafromapi>();

            return builder.Build();
        }
    }
}
