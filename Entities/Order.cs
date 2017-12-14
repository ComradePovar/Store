using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        [Required]
        public virtual Client Client { get; set; }
        public bool IsDeliveryRequired { get; set; }
        public virtual Delivery Delivery { get; set; }
        [Required]
        public string PayType { get; set; }
        public virtual Discount Discount { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
