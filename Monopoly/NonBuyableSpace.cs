using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class NonBuyableSpace : Space
    {
        public string Name { get; set; }
        public NonBuyableSpaceType SpaceType { get; set; }

        public NonBuyableSpace() { }

        public NonBuyableSpace(List<Player> PlayersCurrentlyOnSpace, string Name, NonBuyableSpaceType SpaceType)
        {
            this.PlayersCurrentlyOnSpace = PlayersCurrentlyOnSpace;
            this.Name = Name;
            this.SpaceType = SpaceType;
        }
    }
}
