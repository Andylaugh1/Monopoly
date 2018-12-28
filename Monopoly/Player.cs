using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Monopoly
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public Piece Piece { get; set; } [NotMapped]
        public Dictionary<int, int> Money { get; set; } [NotMapped]
        public bool IsInJail { get; set; }
        public bool IsBankrupt { get; set; }
        public bool IsBanker { get; set; }

        public Player(string Name)
        {
            this.Name = Name;
            this.Piece = Piece;
            this.Money = Money;
            this.IsInJail = false;
            this.IsBankrupt = false;
            this.IsBanker = false;
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