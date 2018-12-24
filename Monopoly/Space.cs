using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class Space
    {
        public List<Player> PlayersCurrentlyOnSpace { get; set; }

        public Space() { }        

        public Space(List<Player> PlayersCurrentlyOnSpace)
        {
            this.PlayersCurrentlyOnSpace = PlayersCurrentlyOnSpace;
        }
    }
}
