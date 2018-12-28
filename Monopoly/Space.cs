using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Monopoly
{
    public class Space
    {
        [Key]
        public int SpaceId { get; set; }
        public List<Player> PlayersCurrentlyOnSpace { get; set; }

        public Space() { }        

        public Space(List<Player> PlayersCurrentlyOnSpace)
        {
            this.PlayersCurrentlyOnSpace = PlayersCurrentlyOnSpace;
        }
    }
}
