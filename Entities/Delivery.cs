using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public string DeliveryType { get; set; }
    }
}
