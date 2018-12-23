using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class NonBuyableSpace : Space
    {
        public string Name;
        public NonBuyableSpaceType SpaceType;

        public NonBuyableSpace(string Name, NonBuyableSpaceType SpaceType)
        {
            this.Name = Name;
            this.SpaceType = SpaceType;
        }
    }
}
