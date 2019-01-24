using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace MyBeerApp.Infrastructure.Shared
{
    public interface IDatabaseContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        Task<int> SaveChangesAsync();
    }
}