using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTests
{
    [TestClass]
    public class StreetTest
    {
        [TestMethod]
        public void Can_Get_StreetName()
        {
            var Properties = new List<Property>();
            Street street1 = new Street("Mayfair", StreetColour.Brown, 400, 100, 500, 250, 200, 400, Properties);
            Assert.AreEqual("Mayfair", street1.Name);
        }

        [TestMethod]
        public void Can_Get_StreetColour()
        {
            var Properties = new List<Property>();
            Street street1 = new Street("Mayfair", StreetColour.Brown, 400, 100, 500, 250, 200, 400, Properties);
            Assert.AreEqual(StreetColour.Brown, street1.Colour);
        }

        [TestMethod]
        public void Can_Get_StreetPrice()
        {
            var Properties = new List<Property>();
            Street street1 = new Street("Mayfair", StreetColour.Brown, 400, 100, 500, 250, 200, 400, Properties);
            Assert.AreEqual(400, street1.Price);
        }

        [TestMethod]
        public void Can_Get_HousePrice()
        {
            var Properties = new List<Property>();
            Street street1 = new Street("Mayfair", StreetColour.Brown, 400, 100, 500, 250, 200, 400, Properties);
            Assert.AreEqual(100, street1.HousePrice);
        }

        [TestMethod]
        public void Can_Get_HotelPrice()
        {
            var Properties = new List<Property>();
            Street street1 = new Street("Mayfair", StreetColour.Brown, 400, 100, 500, 250, 200, 400, Properties);
            Assert.AreEqual(500, street1.HotelPrice);
        }

        [TestMethod]
        public void Can_Get_ReMortgageValue()
        {
            var Properties = new List<Property>();
            Street street1 = new Street("Mayfair", StreetColour.Brown, 400, 100, 500, 250, 200, 400, Properties);
            Assert.AreEqual(250, street1.ReMortgageValue);
        }

        [TestMethod]
        public void Can_Get_RentalCostIfAlone()
        {
            var Properties = new List<Property>();
            Street street1 = new Street("Mayfair", StreetColour.Brown, 400, 100, 500, 250, 200, 400, Properties);
            Assert.AreEqual(200, street1.RentIfAlone);
        }

        [TestMethod]
        public void Can_Get_RentalCostIfSet()
        {
            var Properties = new List<Property>();
            Street street1 = new Street("Mayfair", StreetColour.Brown, 400, 100, 500, 250, 200, 400, Properties);
            Assert.AreEqual(400, street1.RentIfSet);
        }

        [TestMethod]
        public void Can_Get_Properties()
        {
            var Properties = new List<Property>();
            Street street1 = new Street("Mayfair", StreetColour.Brown, 400, 100, 500, 250, 200, 400, Properties);
            Assert.AreEqual(0, street1.Properties.Count);
        }

        [TestMethod]
        public void Can_Get_NumberOfHouses()
        {
            var Properties = new List<Property>();
            var house = new Property(PropertyType.House);
            Properties.Add(house);
            Street street1 = new Street("Mayfair", StreetColour.Brown, 400, 100, 500, 250, 200, 400, Properties);
            Assert.AreEqual(1, street1.CountHouses());
        }

        [TestMethod]
        public void Can_Get_NumberOfHotels()
        {
            var Properties = new List<Property>();
            var hotel = new Property(PropertyType.Hotel);
            Properties.Add(hotel);
            Street street1 = new Street("Mayfair", StreetColour.Brown, 400, 100, 500, 250, 200, 400, Properties);
            Assert.AreEqual(1, street1.CountHotels());
        }
    }
}