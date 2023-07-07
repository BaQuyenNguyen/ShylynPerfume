using ShylynPerfumeAPI.Models;

namespace ShylynPerfumeAPI.Services.CategorySevice
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategories();
        Task<Category> GetSingleCategory(Guid id);
        Task<List<Category>> CreateAsync(Category request);
        Task<List<Category>> UpdateAsync(Guid id, Category request);
        Task<List<Category>> DeleteAsync(Guid id);
    }
}
