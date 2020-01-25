using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using swlibrary.Utilities;
using swlibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swtestunit
{
    [TestClass]
    public class getdatatests
    {
        private Idatafromapi dataapi;

        [TestInitialize]
        public void Initialize()
        {
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                dataapi = scope.Resolve<Idatafromapi>();
            }
        }

        [TestMethod]
        public void testgetstarships_null()
        {
            //act
            starships ships = dataapi.getstarshipsfromapi(null);

            //assert
            Assert.IsNull(ships);
        }

        [TestMethod]
        public void testgetstarships_success()
        {
            //act
            starships ships = dataapi.getstarshipsfromapi("");

            //assert
            Assert.IsNotNull(ships);
        }

        [TestMethod]
        public void testgetstarships_wrongurl()
        {
            //act
            starships ships = dataapi.getstarshipsfromapi("myapi");

            //assert
            Assert.IsNull(ships);
        }
    }
}
