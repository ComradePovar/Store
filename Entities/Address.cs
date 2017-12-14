using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
    }
}
