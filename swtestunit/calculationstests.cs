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
            decimal dblnbhours = cal.getdurabilityofconsumableinhours("2 years");

            //assert
            Assert.AreEqual(17520, dblnbhours);
        }

        [TestMethod]
        public void testcunsumableconversiontohours_wrongparam()
        {
            //act
            decimal dblnbhours = cal.getdurabilityofconsumableinhours("myyears");

            //assert
            Assert.AreEqual(0, dblnbhours);
        }

        [TestMethod]
        public void testcunsumableconversiontohours_unavailableunits()
        {
            //act
            decimal dblnbhours = cal.getdurabilityofconsumableinhours("2 centuries");

            //assert
            Assert.AreEqual(0, dblnbhours);
        }

        [TestMethod]
        public void testcunsumableconversiontohours_1month()
        {
            //act
            decimal dblnbhours = cal.getdurabilityofconsumableinhours("1 month");

            //assert
            Assert.AreEqual(730, dblnbhours);
        }

        [TestMethod]
        public void testcunsumableconversiontohours_3months()
        {
            //act
            decimal dblnbhours = cal.getdurabilityofconsumableinhours("3 months");

            //assert
            Assert.AreEqual(2190, dblnbhours);
        }

        [TestMethod]
        public void testcunsumableconversiontohours_1week()
        {
            //act
            decimal dblnbhours = cal.getdurabilityofconsumableinhours("1 week");

            //assert
            Assert.AreEqual(168, dblnbhours);
        }

        [TestMethod]
        public void testcunsumableconversiontohours_6weeks()
        {
            //act
            decimal dblnbhours = cal.getdurabilityofconsumableinhours("6 weeks");

            //assert
            Assert.AreEqual(1008, dblnbhours);
        }

        [TestMethod]
        public void testcunsumableconversiontohours_1day()
        {
            //act
            decimal dblnbhours = cal.getdurabilityofconsumableinhours("1 day");

            //assert
            Assert.AreEqual(24, dblnbhours);
        }

        [TestMethod]
        public void testcunsumableconversiontohours_12days()
        {
            //act
            decimal dblnbhours = cal.getdurabilityofconsumableinhours("12 days");

            //assert
            Assert.AreEqual(288, dblnbhours);
        }

        [TestMethod]
        public void testcunsumableconversiontohours_1hour()
        {
            //act
            decimal dblnbhours = cal.getdurabilityofconsumableinhours("1 hour");

            //assert
            Assert.AreEqual(1, dblnbhours);
        }

        [TestMethod]
        public void testcunsumableconversiontohours_8hours()
        {
            //act
            decimal dblnbhours = cal.getdurabilityofconsumableinhours("8 hours");

            //assert
            Assert.AreEqual(8, dblnbhours);
        }

        [TestMethod]
        public void testnumberstops_0disancenullspeedandconsumables()
        {
            //act
            int nbstops = cal.getnumberofstops(0, null, null);

            //assert
            Assert.AreEqual(0, nbstops);
        }

        [TestMethod]
        public void testnumberstops_nullspeedemptyconsumables()
        {
            //act
            int nbstops = cal.getnumberofstops(1000, null, "");

            //assert
            Assert.AreEqual(-1, nbstops);
        }

        [TestMethod]
        public void testnumberstops_rmptyspeednullconsumables()
        {
            //act
            int nbstops = cal.getnumberofstops(1000, "", null);

            //assert
            Assert.AreEqual(-1, nbstops);
        }
    }
}
