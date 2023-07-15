using ShylynPerfumeAPI.Models;

namespace ShylynPerfumeAPI.Services.InterfaceServices
{
    public interface IUserService
    {
        Task<List<Category>> GetAllCategories();
        Task<Category> GetSingleCategory(Guid id);
        Task<List<Category>> CreateAsync(Category request);
        Task<List<Category>> UpdateAsync(Guid id, Category request);
        Task<List<Category>> DeleteAsync(Guid id);
    }
}
