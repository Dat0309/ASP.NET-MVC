using System;
using System.Collections.Generic;

#nullable disable

namespace WebExercise.Models
{
    public partial class TransactStatus
    {
        public TransactStatus()
        {
            Orders = new HashSet<Order>();
        }

        public int TransacStatusId { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
