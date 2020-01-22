using Autofac;
using swlibrary.Utilities;
using System;

namespace swconsoleapp
{
    class Program
    {
        /// <summary>
        /// the first instance of the console app
        /// </summary>
        /// <param name="args">if we're calling the app and need to send any arguments</param>
        static void Main(string[] args)
        {
            ///calling the method that is applying the dependency injetion
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}
