using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        [Required]
        public string ClientType { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public string Fax { get; set; }
        public virtual Address Address { get; set; }
        public virtual Address BillingAddress { get; set; }
    }
}
