using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class RailwayStation : Space
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int ReMortgageValue { get; set; }
        public int RentIfAlone { get; set; }
        public int RentIfSet { get; set; }

        public RailwayStation() { }

        public RailwayStation(List<Player> PlayersCurrentlyOnSpace, string Name, int Price, int ReMortgageValue, int RentIfAlone, int RentIfSet)
        {
            this.PlayersCurrentlyOnSpace = PlayersCurrentlyOnSpace;
            this.Name = Name;
            this.Price = Price;
            this.ReMortgageValue = ReMortgageValue;
            this.RentIfAlone = RentIfAlone;
            this.RentIfSet = RentIfSet;
        }
    }
}
