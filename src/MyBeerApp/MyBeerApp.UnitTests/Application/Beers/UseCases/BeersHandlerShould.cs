using FluentAssertions;
using MyBeerApp.Application.Beers.UseCases;
using MyBeerApp.Domain.Beers;
using MyBeerApp.Infrastructure.Shared;
using Xunit;

namespace MyBeerApp.UnitTests.Application.Beers.UseCases
{
    public class BeersHandlerShould : IClassFixture<CustomTestFixture>
    {
        private readonly CustomTestFixture _fixture;

        public BeersHandlerShould(CustomTestFixture fixture) =>
            _fixture = fixture;

        [Fact]
        public void Construct()
        {
            // Run the test against one instance of the context
            using (var context = new MyBeerAppContext(_fixture.dbContextOptions))
            {
                var beerRepository = new EfRepository<Beer>(context);
                var handler = new BeersHandler(beerRepository);
                handler.Should().NotBeNull().And.BeOfType<BeersHandler>();
            }
        }
    }
}