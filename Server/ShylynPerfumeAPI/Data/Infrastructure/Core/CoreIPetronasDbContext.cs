using ShylynPerfumeAPI.Models;

namespace ShylynPerfumeAPI.Data.Infrastructure.Core
{
    public partial interface CoreIDbContext : IDisposable
    {
        #region Identity
        DbSet<User> Users { get; set; }
        #endregion

        #region Master Data
        DbSet<Category> Categories { get; set; }
        #endregion
    }
}
