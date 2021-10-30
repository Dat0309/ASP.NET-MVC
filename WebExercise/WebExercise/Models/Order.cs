using System;
using System.Collections.Generic;

#nullable disable

namespace WebExercise.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public int? TransactStatus { get; set; }
        public bool Deleted { get; set; }
        public bool Paid { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? PaymentId { get; set; }
        public string Note { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual TransactStatus TransactStatusNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
