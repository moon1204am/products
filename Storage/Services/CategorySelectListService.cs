using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Storage.Data;

namespace Storage.Services
{
    public class CategorySelectListService : ICategorySelectListService
    {
        private readonly StorageContext _storageRepository;

        public CategorySelectListService(StorageContext storageRepository)
        {
            _storageRepository = storageRepository;
        }

        public async Task<IEnumerable<SelectListItem>> GetCategoriesAsync()
        {
            return await _storageRepository.Product.Select(p => p.Category)
                .Distinct()
                .Select(p => new SelectListItem
                {
                    Text = p.ToString(),
                    Value = p.ToString()
                })
                .ToListAsync();
        }
    }
}
