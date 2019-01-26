using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace MyBeerApp.IntegrationTests.Web
{
    [Collection(Constants.WEB_DATABASE_FIXTURE)]
    public class HomePageShould
    {
        private readonly WebTestDatabaseFixture _fixture;

        public HomePageShould(WebTestDatabaseFixture fixture) =>
            _fixture = fixture;

        [Fact]
        public async Task ReturnOk()
        {
            var response = await _fixture.Client.GetAsync("/");
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}