using ShylynPerfumeAPI.Data.Infrastructure.Core;
using ShylynPerfumeAPI.Models;
using ShylynPerfumeAPI.Services.InterfaceServices;

namespace ShylynPerfumeAPI.Services.ImpServices
{
    public class UserService : IUserService
    {

        private readonly CoreDataContext _context;

        public UserService(CoreDataContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> Authenticate(User user)
        {
            if(user is null)
            {
                return null;
            }

            var userItem = await _context.Users.GetQuery
            return categories;
        }

        public async Task<Category> GetSingleCategory(Guid id)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category is null)
                return null;
            return category;
        }

        public async Task<List<Category>> CreateAsync(Category request)
        {
            _context.Categories.Add(request);
            await _context.SaveChangesAsync();
            return await _context.Categories.ToListAsync();
        }

        public async Task<List<Category>> UpdateAsync(Guid id, Category request)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category is null)
                return null;

            category.Name = request.Name;
            category.Description = request.Description;

            await _context.SaveChangesAsync();
            return await _context.Categories.ToListAsync();
        }

        public async Task<List<Category>> DeleteAsync(Guid id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category is null)
                return null;

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return await _context.Categories.ToListAsync();
        }
    }
}
