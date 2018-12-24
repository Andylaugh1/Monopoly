using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTests
{
    [TestClass]
    public class MiddleCardTest
    {
        MiddleCard middleCard1;

        [TestInitialize]
        public void TestInitialize()
        {
            middleCard1 = new MiddleCard("Chance", "Go to jail. Go directly to jail, do not pass go, do not collect £200");
        }

        [TestMethod]
        public void Can_Get_Name()
        {
            Assert.AreEqual("Chance", middleCard1.Name);
        }

        [TestMethod]
        public void Can_Get_Instruction()
        {
            Assert.AreEqual("Go to jail. Go directly to jail, do not pass go, do not collect £200", middleCard1.Instruction);
        }
    }
}
