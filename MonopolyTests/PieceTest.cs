using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTests
{
    [TestClass]
    public class PieceTest
    {
        [TestMethod]
        public void Can_Get_PieceName()
        {
            Piece piece1 = new Piece("Andy");
            var Result = "Andy";
            Assert.AreEqual(Result, piece1.Name);
        }
    }
}
