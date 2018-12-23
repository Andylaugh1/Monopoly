using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTests
{
    [TestClass]
    public class PropertyTest
    {
        [TestMethod]
        public void Can_Get_PropertyType()
        {
            Property property1 = new Property(PropertyType.House);
            Assert.AreEqual(PropertyType.House, property1.Type);
        }

    }
}
