using System;
using System.Collections.Generic;

#nullable disable

namespace WebExercise.Models
{
    public partial class Attribute
    {
        public Attribute()
        {
            AttributesPrces = new HashSet<AttributesPrce>();
        }

        public int AttributeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AttributesPrce> AttributesPrces { get; set; }
    }
}
