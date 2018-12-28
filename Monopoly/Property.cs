using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Monopoly
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }
        public PropertyType Type { get; set; } 

        public Property(PropertyType Type)
        {
            this.Type = Type;
        }

    }
}