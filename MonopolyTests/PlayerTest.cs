using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTests
{
    [TestClass]
    public class PlayerTest
    {
        Piece piece1;
        Player player1;
        Dictionary<int, int> Money;

        [TestInitialize]
        public void TestInitialize()
        {
            Money = new Dictionary<int, int>();
            piece1 = new Piece("Car");
            player1 = new Player("Andy", piece1, Money);
        }

        [TestMethod]
        public void Can_Get_Player_Name()
        {
            Assert.AreEqual("Andy", player1.Name);
        }

        [TestMethod]
        public void Can_Get_Player_Piece_Name()
        {
            var piece1Name = piece1.Name;

            Assert.AreEqual("Car", piece1Name);
        }

        [TestMethod]
        public void Can_Get_Player_Money_Total()
        {
            Money.Add(1, 10);
            Money.Add(5, 5);
            Money.Add(10, 2);
            Money.Add(20, 2);
            Money.Add(50, 1);
            Money.Add(100, 5);
            Money.Add(500, 1);

            Assert.AreEqual(1145, player1.GetTotalMoney());                       
        }

        [TestMethod]
        public void Can_Get_Quantity_Of_Desired_Denomination()
        {
            Money.Add(1, 10);
            Money.Add(5, 5);
            Money.Add(10, 2);
            Money.Add(20, 2);
            Money.Add(50, 1);
            Money.Add(100, 5);
            Money.Add(500, 1);

            Assert.AreEqual(5, player1.GetDenominationQuantity(100));
        }

        [TestMethod]
        public void Can_Check_If_Player_In_Jail_false()
        {
            Assert.AreEqual(false, player1.IsInJail);
        }

        [TestMethod]
        public void Can_Check_If_Player_Is_Bankrupt_false()
        {
            Assert.AreEqual(false, player1.IsBankrupt);
        }

        [TestMethod]
        public void Can_Check_If_Player_Is_Banker_false()
        {
            Assert.AreEqual(false, player1.IsBanker);
        }

        [TestMethod]
        public void Can_Check_If_Player_Is_InJail_Banker_Bankrupt_true()
        {
            player1.IsBanker = true;
            player1.IsBankrupt = true;
            player1.IsInJail = true;

            Assert.AreEqual(true, player1.IsBanker);
            Assert.AreEqual(true, player1.IsInJail);
            Assert.AreEqual(true, player1.IsBankrupt);
        }


    }
}
