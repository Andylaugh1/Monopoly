using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTests
{
    [TestClass]
    public class RailwayStationTest
    {
        RailwayStation station1;

        [TestInitialize]
        public void TestInitialize()
        {
            var playersOnSpace = new List<Player>();

            station1 = new RailwayStation(playersOnSpace, "Fenchurch Street", 200, 50, 50, 200);
        }

        [TestMethod]
        public void Can_Get_Name()
        {
            Assert.AreEqual("Fenchurch Street", station1.Name);
        }

        [TestMethod]
        public void Can_Get_Price()
        {
            Assert.AreEqual(200, station1.Price);
        }

        [TestMethod]
        public void Can_Get_ReMortgageValue()
        {
            Assert.AreEqual(50, station1.ReMortgageValue);
        }

        [TestMethod]
        public void Can_Get_RenIfAlone()
        {
            Assert.AreEqual(50, station1.RentIfAlone);
        }

        [TestMethod]
        public void Can_Get_RentIfSet()
        {
            Assert.AreEqual(200, station1.RentIfSet);
        }
    }
}
