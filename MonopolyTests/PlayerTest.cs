using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTests
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void Can_Get_Player_Name()
        {
            var Money = new Dictionary<int, int>();
            Piece piece1 = new Piece("Car");
            Player player1 = new Player("Andy", piece1, Money);

            Assert.AreEqual("Andy", player1.Name);
        }

        [TestMethod]
        public void Can_Get_Player_Piece_Name()
        {
            var Money = new Dictionary<int, int>();
            Piece piece1 = new Piece("Car");
            Player player1 = new Player("Andy", piece1, Money);
            var piece1Name = piece1.Name;

            Assert.AreEqual("Car", piece1Name);
        }

        [TestMethod]
        public void Can_Get_Player_Money_Total()
        {
            var Money = new Dictionary<int, int>();
            Piece piece1 = new Piece("Car");
            Player player1 = new Player("Andy", piece1, Money);
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
            var Money = new Dictionary<int, int>();
            Piece piece1 = new Piece("Car");
            Player player1 = new Player("Andy", piece1, Money);
            Money.Add(1, 10);
            Money.Add(5, 5);
            Money.Add(10, 2);
            Money.Add(20, 2);
            Money.Add(50, 1);
            Money.Add(100, 5);
            Money.Add(500, 1);

            Assert.AreEqual(5, player1.GetDenominationQuantity(100));
        }


    }
}
