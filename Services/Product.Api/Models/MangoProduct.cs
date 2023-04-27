using System.ComponentModel.DataAnnotations;

namespace Product.Api.Models
{
    public class MangoProduct
    {
        [Key] 
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1,100)]
        public double Price { get; set; }

        public string Description { get; set; }

        public string CategoryName { get; set; }

        public string ImageUrl { get; set; }
    }
}
