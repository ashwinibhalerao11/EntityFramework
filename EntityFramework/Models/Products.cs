using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EntityFramework.Models
{
    [Table("Products")]
    public class Products
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Company { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
