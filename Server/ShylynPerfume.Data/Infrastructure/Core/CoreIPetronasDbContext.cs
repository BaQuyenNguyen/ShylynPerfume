using ShylynPerfumeAPI.Models;

namespace ShylynPerfume.Data.Infrastructure.Core
{
    public partial interface CoreIDbContext : IDisposable
    {
        #region Identity
        DbSet<ApplicationUser> Users { get; set; }
        #endregion

        #region Master Data
        DbSet<Category> Categories { get; set; }
        #endregion
    }
}
