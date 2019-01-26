using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyBeerApp.Domain.Beers;
using MyBeerApp.Domain.Shared;
using MyBeerApp.Infrastructure.Shared;
using MyBeerApp.Mocks.Beers;
using Refit;
using System;

namespace MyBeerApp.IntegrationTests
{
    public class ApiTestDatabaseFixture : IDisposable
    {
        public readonly IApiDefinition Api;

        public ApiTestDatabaseFixture()
        {
            var options = new DbContextOptionsBuilder<MyBeerAppContext>()
                .UseInMemoryDatabase(databaseName: "in-mem-api-test-database")
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
                .UseStartup<MyBeerApp.Api.Startup>());

            var client = server.CreateClient();

            Api = RestService.For<IApiDefinition>(client);
        }

        public void Dispose()
        {
        }
    }
}