using System.ComponentModel.DataAnnotations;

namespace Storage.Models.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        [Display(Name = "Inventory Value")]
        public int InventoryValue { get; set; }
    }
}
