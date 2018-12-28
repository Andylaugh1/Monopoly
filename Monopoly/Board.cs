using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Monopoly
{
    public class Board
    {
        [Key]
        public int BoardId { get; set; }
        public List<Space> Spaces { get; set; }
    }
}
