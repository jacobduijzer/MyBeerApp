using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MyBeerApp.Infrastructure.Shared
{
    public class MyBeerAppContextFactory : IDesignTimeDbContextFactory<MyBeerAppContext>
    {
        public MyBeerAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyBeerAppContext>();
            optionsBuilder.UseSqlServer(args[0]);
            return new MyBeerAppContext(optionsBuilder.Options);
        }
    }
}