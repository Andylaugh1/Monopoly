using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Monopoly
{
    public class Dice
    {
        public Random Random { get; set; }
        public int SidesCount { get; set; }

        public Dice()
        {
            this.SidesCount = 6;
            this.Random = new Random();
        }

        public int Roll()
        {
            return this.Random.Next(1, this.SidesCount + 1);
        }
    }
}
