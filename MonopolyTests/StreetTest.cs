using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTests
{
    [TestClass]
    public class StreetTest
    {
        Street street1;
        List<Property> properties;

        [TestInitialize]
        public void TestInitialize()
        {
            properties = new List<Property>();
            var playersOnSpace = new List<Player>();

            street1 = new Street(playersOnSpace, "Mayfair", StreetColour.Brown, 400, 100, 500, 250, 200, 400, properties);
        }

        [TestMethod]
        public void Can_Get_StreetName()
        {
           
            Assert.AreEqual("Mayfair", street1.Name);
        }

        [TestMethod]
        public void Can_Get_StreetColour()
        {
            Assert.AreEqual(StreetColour.Brown, street1.Colour);
        }

        [TestMethod]
        public void Can_Get_StreetPrice()
        {
            Assert.AreEqual(400, street1.Price);
        }

        [TestMethod]
        public void Can_Get_HousePrice()
        {
            Assert.AreEqual(100, street1.HousePrice);
        }

        [TestMethod]
        public void Can_Get_HotelPrice()
        {
            Assert.AreEqual(500, street1.HotelPrice);
        }

        [TestMethod]
        public void Can_Get_ReMortgageValue()
        {
            Assert.AreEqual(250, street1.ReMortgageValue);
        }

        [TestMethod]
        public void Can_Get_RentalCostIfAlone()
        {
            Assert.AreEqual(200, street1.RentIfAlone);
        }

        [TestMethod]
        public void Can_Get_RentalCostIfSet()
        {
            Assert.AreEqual(400, street1.RentIfSet);
        }

        [TestMethod]
        public void Can_Get_Properties()
        {
            Assert.AreEqual(0, street1.Properties.Count);
        }

        [TestMethod]
        public void Can_Get_NumberOfHouses()
        {
            var house = new Property(PropertyType.House);
            properties.Add(house);
            Assert.AreEqual(1, street1.CountHouses());
        }

        [TestMethod]
        public void Can_Get_NumberOfHotels()
        {
            var hotel = new Property(PropertyType.Hotel);
            properties.Add(hotel);
            Assert.AreEqual(1, street1.CountHotels());
        }
    }
}