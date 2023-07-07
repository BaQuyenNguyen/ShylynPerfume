﻿global using Microsoft.EntityFrameworkCore;
using ShylynPerfumeAPI.Models;

namespace ShylynPerfumeAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost;Database=ShylynPerfume;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Category> Categories { get; set; }
    }
}