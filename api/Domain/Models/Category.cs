using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("categories_tb")]
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
