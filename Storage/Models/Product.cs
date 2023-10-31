using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public int Price { get; set; }
        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Category { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
    }
}
