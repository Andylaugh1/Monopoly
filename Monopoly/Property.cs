using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class Property
    {
        public PropertyType Type { get; set; } 

        public Property(PropertyType Type)
        {
            this.Type = Type;
        }

    }
}