﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTests
{
    [TestClass]
    public class NonBuyableSpaceTest
    {
        NonBuyableSpace space1;

        [TestInitialize]
        public void TestInitialize()
        {
            var playersOnSpace = new List<Player>();

            space1 = new NonBuyableSpace(playersOnSpace, "Community Chest", NonBuyableSpaceType.Community_Chest);
        }

        [TestMethod]
        public void Can_Get_Space_Name()
        {
            Assert.AreEqual("Community Chest", space1.Name);
        }

        [TestMethod]
        public void Can_Get_Space_Type()
        {
            Assert.AreEqual(NonBuyableSpaceType.Community_Chest, space1.SpaceType);
        }
    }
}
