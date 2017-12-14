using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public virtual ProductInfo ProductInfo { get; set; }
        public virtual Supplier Supplier { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStore { get; set; }
        public int QuantityInStock { get; set; }
    }
}
