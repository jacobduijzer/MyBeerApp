using Microsoft.EntityFrameworkCore;

namespace MyBeerApp.Infrastructure.Shared
{
    public static class DatabaseContextFactory
    {
        public static IDatabaseContext ProductionContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyBeerAppContext>()
                .UseSqlServer(Constants.CONNECTION_STRING);

            return new MyBeerAppContext(optionsBuilder.Options);
        }

        // TODO: create test context?
    }
}