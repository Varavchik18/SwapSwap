using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("products_tb")]
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string? City { get; set; }
        public string? Image { get; set; }
        public Category? Category { get; set; }
    }
}