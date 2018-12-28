using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Monopoly
{
    public class MiddleCard
    {
        [Key]
        public int MiddleCardId { get; set; }
        public string Name { get; set; }
        public string Instruction { get; set; }

        public MiddleCard(string Name, string Instruction)
        {
            this.Name = Name;
            this.Instruction = Instruction;
        }
    }
}
