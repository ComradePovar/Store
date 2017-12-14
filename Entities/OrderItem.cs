using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        [Required]
        public virtual Product Product { get; set; }
        [Required]
        public virtual Order Order { get; set; }
        public int Quantity { get; set; }
        [Required]
        public string DeliveryType { get; set; }
    }
}
