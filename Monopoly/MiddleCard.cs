using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class MiddleCard
    {
        public string Name { get; set; }
        public string Instruction { get; set; }

        public MiddleCard(string Name, string Instruction)
        {
            this.Name = Name;
            this.Instruction = Instruction;
        }
    }
}
