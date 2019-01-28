using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Azure.Services.AppAuthentication;

namespace MyBeerApp.Infrastructure.Shared
{
    public class MyBeerAppContextFactory : IDesignTimeDbContextFactory<MyBeerAppContext>
    {
        public MyBeerAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyBeerAppContext>();
            optionsBuilder.UseSqlServer(args[0]);

            //if (conn.DataSource != "(localdb)\\MSSQLLocalDB")
            //    conn.AccessToken = (new AzureServiceTokenProvider()).GetAccessTokenAsync("https://database.windows.net/").Result;

            //Database.SetInitializer<MyDatabaseContext>(null);

            //optionsBuilder.top

            return new MyBeerAppContext(optionsBuilder.Options);
        }
    }
}