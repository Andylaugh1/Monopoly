using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class Player
    {
        public string Name { get; set; }
        public Piece Piece { get; set; }
        public Dictionary<int, int> Money { get; set; }
        public bool IsInJail { get; set; }

        public Player(string Name, Piece Piece, Dictionary<int, int> Money)
        {
            this.Name = Name;
            this.Piece = Piece;
            this.Money = Money;
            this.IsInJail = false;
        }

        public int GetTotalMoney()
        {
            var TotalMoneyCount = 0;

            foreach(var key in this.Money)
            {
                var DenominationTotal = key.Key * key.Value;
                TotalMoneyCount += DenominationTotal;
            }

            return TotalMoneyCount;
        }

        public int GetDenominationQuantity(int denomination)
        {
            var DenominationQuantity = 0;

            foreach(var key in this.Money)
            {
                if(key.Key == denomination)
                {
                    DenominationQuantity = key.Value;
                }
            }
            return DenominationQuantity;
        }
    }
}