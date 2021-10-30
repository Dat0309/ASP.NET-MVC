using System;
using System.Collections.Generic;

#nullable disable

namespace WebExercise.Models
{
    public partial class AttributesPrce
    {
        public int AttributePriceId { get; set; }
        public int? AttributeId { get; set; }
        public int? ProductId { get; set; }
        public int? Price { get; set; }
        public bool Active { get; set; }

        public virtual Attribute Attribute { get; set; }
        public virtual Product Product { get; set; }
    }
}
