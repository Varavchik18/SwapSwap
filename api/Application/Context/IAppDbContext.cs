using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Context
{
    public interface IAppDbContext
    {
        DbSet<Category> Categories { get; }
        DbSet<Product> Products { get; }

        Task<int> SaveToDbAsync();
    }
}
