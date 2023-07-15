global using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Debug;
using ShylynPerfumeAPI.Models;

namespace ShylynPerfume.Data.Infrastructure.Core
{
    public class CoreDataContext : DbContext
    {
        public static readonly LoggerFactory MyLoggerFactory = new LoggerFactory(new[] { new DebugLoggerProvider() });
        public CoreDataContext(DbContextOptions<CoreDataContext> options) : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("Server=localhost;Database=ShylynPerfume;Trusted_Connection=true;TrustServerCertificate=true;");
        //}

        public DbSet<Category> Categories { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().ToTable("Users");
        }
    }
}