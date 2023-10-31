namespace Storage.Models.ViewModels
{
    public class ProductSearchParamsViewModel
    {
        public IEnumerable<ProductViewModel> ProductViewModel { get; set; }
        public FilterDTO FilterDTO { get; set; }
    }
}
