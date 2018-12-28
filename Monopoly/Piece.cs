using System;
using System.ComponentModel.DataAnnotations;

namespace Monopoly
{
    public class Piece
    {
        [Key]
        public int PieceId { get; set; }
        public string Name { get; set; }

        public Piece(string Name)
        {
            this.Name = Name;
        }
    }
}
