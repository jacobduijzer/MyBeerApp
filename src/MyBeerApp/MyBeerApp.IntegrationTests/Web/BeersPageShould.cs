using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace MyBeerApp.IntegrationTests.Web
{
    public class BeersPageShould : IClassFixture<WebTestFixture>
    {
        private readonly WebTestFixture _fixture;

        public BeersPageShould(WebTestFixture fixture) =>
            _fixture = fixture;

        [Fact]
        public async Task ReturnOk()
        {
            var response = await _fixture.Client.GetAsync("/Beers");
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}