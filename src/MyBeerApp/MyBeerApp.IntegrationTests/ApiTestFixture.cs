using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System;

namespace MyBeerApp.IntegrationTests
{
    public class ApiTestFixture : IDisposable
    {
        public readonly IApiDefinition Api;

        public ApiTestFixture()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment(EnvironmentName.Development)
                .ConfigureTestServices((IServiceCollection serviceCollection) =>
                {
                    // Use stubbed database for integration tests
                    //serviceCollection.AddSingleton<IDatabase<Beer>, StubBeerDatabase>();
                    //serviceCollection.AddSingleton<IDatabase<Bar>, StubBarDatabase>();
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