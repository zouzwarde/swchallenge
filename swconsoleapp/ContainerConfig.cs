using Autofac;
using swlibrary;
using swlibrary.Utilities;
using System.Linq;
using System.Reflection;

namespace swconsoleapp
{
    /// <summary>
    /// this class is static so we need not to instantiate it 
    /// in this class we are linking objects with interfaces and is used 
    /// to create an instance of the objects whenever needed 
    /// without to make this creating explicitly "Dependency injection"
    /// </summary>
    public static class ContainerConfig
    {
        public static Autofac.IContainer Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<businesslogic>().As<Ibusinesslogic>();

            builder.RegisterType<calculations>().As<Icalculations>();
            builder.RegisterType<datafromapi>().As<Idatafromapi>();
            builder.RegisterType<display>().As<Idisplay>();

            return builder.Build();
        }
    }
}
