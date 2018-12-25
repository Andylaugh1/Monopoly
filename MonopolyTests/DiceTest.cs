using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTests
{
    [TestClass]
    public class DiceTest
    {
        Dice dice1;

        [TestInitialize]
        public void TestInitialize()
        {
            dice1 = new Dice();
        }

        [TestMethod]
        public void Can_Get_Number_Of_Sides()
        {
            Assert.AreEqual(6, dice1.SidesCount);
        }
        
        [TestMethod]
        public void Can_Roll_Dice_For_Random_Number()
        {
            Assert.AreEqual(4, dice1.Roll());
        }
    }
}
