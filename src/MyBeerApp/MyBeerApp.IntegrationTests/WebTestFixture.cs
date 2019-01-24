using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

namespace MyBeerApp.IntegrationTests
{
    public class WebTestFixture : IDisposable
    {
        public HttpClient Client;

        public WebTestFixture()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment(EnvironmentName.Development)
                .ConfigureTestServices((IServiceCollection serviceCollection) =>
                {
                    // Use stubbed database for integration tests
                    //serviceCollection.AddSingleton<IDatabase<Beer>, StubBeerDatabase>();
                    //serviceCollection.AddSingleton<IDatabase<Bar>, StubBarDatabase>();
                })
                .UseStartup<MyBeerApp.Web.Startup>());

            Client = server.CreateClient();
        }

        public void Dispose()
        {
        }
    }
}