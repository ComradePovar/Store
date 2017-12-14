using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}