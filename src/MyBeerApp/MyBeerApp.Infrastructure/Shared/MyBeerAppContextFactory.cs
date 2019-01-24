using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MyBeerApp.Infrastructure.Shared
{
    public class MyBeerAppContextFactory : IDesignTimeDbContextFactory<MyBeerAppContext>
    {
        public MyBeerAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyBeerAppContext>();
            optionsBuilder.UseSqlServer(Constants.CONNECTION_STRING);
            return new MyBeerAppContext(optionsBuilder.Options);
        }
    }
}