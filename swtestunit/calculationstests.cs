using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using swlibrary.Utilities;
using Autofac;

namespace swtestunit
{
    [TestClass]
    public class calculationstests
    {
        private Icalculations cal;

        [TestInitialize]
        public void Initialize()
        {
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                cal = scope.Resolve<Icalculations>();
            }
        }

        [TestMethod]
        public void testcunsumableconversiontohours_null()
        {
            //act
            decimal dblnbhours = cal.getdurabilityofconsumableinhours(null);

            //assert
            Assert.AreEqual(0, dblnbhours);
        }

        [TestMethod]
        public void testcunsumableconversiontohours_empty()
        {
            //act
            decimal dblnbhours = cal.getdurabilityofconsumableinhours("");

            //assert
            Assert.AreEqual(0, dblnbhours);
        }

        [TestMethod]
        public void testcunsumableconversiontohours_unformatted1year()
        {
            //act
            decimal dblnbhours = cal.getdurabilityofconsumableinhours("   1    year   ");

            //assert
            Assert.AreEqual(8760, dblnbhours);
        }

        [TestMethod]
        public void testcunsumableconversiontohours_unordered()
        {
            //act
            decimal dblnbhours = cal.getdurabilityofconsumableinhours("  year  1 ");

            //assert
            Assert.AreEqual(0, dblnbhours);
        }

        [TestMethod]
        public void testcunsumableconversiontohours_1year()
        {
            //act
            decimal dblnbhours = cal.getdurabilityofconsumableinhours("1 year");

            //assert
            Assert.AreEqual(8760, dblnbhours);
        }

        [TestMethod]
        public void testcunsumableconversiontohours_2year()
        {
            //act
            decimal dblnbhours = cal.getdurabilityofconsumableinhours("2 year");

            //assert
            Assert.AreEqual(17520, dblnbhours);
        }
    }
}
