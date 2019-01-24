using Microsoft.EntityFrameworkCore;
using MyBeerApp.Domain.Beers;

namespace MyBeerApp.Infrastructure.Shared
{
    public class MyBeerAppContext : DbContext
    {
        public MyBeerAppContext(DbContextOptions<MyBeerAppContext> options)
           : base(options)
        { }

        public DbSet<Beer> Beers { get; set; }
    }
}