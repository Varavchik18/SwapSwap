using Application.Context;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories {get; set; }

        public DbSet<Product> Products {get; set; }

        public async Task<int> SaveToDbAsync()
        {
            return await SaveChangesAsync();
        }
    }
}
