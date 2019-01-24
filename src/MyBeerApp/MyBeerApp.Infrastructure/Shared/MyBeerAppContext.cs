using Microsoft.EntityFrameworkCore;
using MyBeerApp.Domain.Beers;
using System.Threading.Tasks;

namespace MyBeerApp.Infrastructure.Shared
{
    public class MyBeerAppContext : DbContext, IDatabaseContext
    {
        public MyBeerAppContext(DbContextOptions<MyBeerAppContext> options)
           : base(options)
        { }

        public DbSet<Beer> Beers { get; set; }

        public async Task<int> SaveChangesAsync() =>
            await base.SaveChangesAsync().ConfigureAwait(false);
    }
}