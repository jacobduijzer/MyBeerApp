using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyBeerApp.Domain.Beers;
using MyBeerApp.Domain.Shared;
using MyBeerApp.Infrastructure.Shared;
using MyBeerApp.Mocks.Beers;
using System;
using System.Net.Http;

namespace MyBeerApp.IntegrationTests
{
    public class WebTestDatabaseFixture : IDisposable
    {
        public HttpClient Client;

        public WebTestDatabaseFixture()
        {
            var options = new DbContextOptionsBuilder<MyBeerAppContext>()
                .UseInMemoryDatabase(databaseName: "in-mem-web-test-database")
                .Options;

            var dbContext = new MyBeerAppContext(options);
            dbContext.Beers.AddRange(BeerData.Beers);
            dbContext.SaveChanges();

            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment(EnvironmentName.Development)
                .ConfigureTestServices((IServiceCollection serviceCollection) =>
                {
                    // Use stubbed database for integration tests
                    serviceCollection.AddScoped<MyBeerAppContext>(x => dbContext);
                    serviceCollection.AddScoped<IRepository<Beer>, EfRepository<Beer>>();
                })
                .UseStartup<MyBeerApp.Web.Startup>());

            Client = server.CreateClient();
        }

        public void Dispose()
        {
        }
    }
}