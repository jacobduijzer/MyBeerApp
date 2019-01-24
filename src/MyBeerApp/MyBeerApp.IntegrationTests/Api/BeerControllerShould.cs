using FluentAssertions;
using System.Threading.Tasks;
using Xunit;

namespace MyBeerApp.IntegrationTests.Api
{
    public class BeerControllerShould : IClassFixture<ApiTestFixture>
    {
        private readonly ApiTestFixture _fixture;

        public BeerControllerShould(ApiTestFixture fixture) =>
            _fixture = fixture;

        [Fact]
        public async Task GetAllBeers()
        {
            var response = await _fixture.Api.GetAllBeers();
            response.Should().NotBeNullOrEmpty();
            response.Should().HaveCount(5);
        }
    }
}