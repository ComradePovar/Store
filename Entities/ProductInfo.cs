using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductInfo
    {
        public int ProductInfoId { get; set; }
        [Required]
        public virtual Category Category { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Serial { get; set; }
    }
}
