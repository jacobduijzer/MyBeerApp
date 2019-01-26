using FluentAssertions;
using System.Threading.Tasks;
using Xunit;

namespace MyBeerApp.IntegrationTests.Api
{
    [Collection(Constants.API_DATABASE_FIXTURE)]
    public class BeerControllerShould
    {
        private readonly ApiTestDatabaseFixture _fixture;

        public BeerControllerShould(ApiTestDatabaseFixture fixture) =>
            _fixture = fixture;

        [Fact]
        public async Task GetAllBeers()
        {
            var response = await _fixture.Api.GetAllBeers();
            response.Should().NotBeNullOrEmpty();
            response.Should().HaveCount(2);
        }
    }
}