using FluentAssertions;
using MyBeerApp.Domain.Beers;
using Xunit;

namespace MyBeerApp.UnitTests.Domain.Beers
{
    public class BeerShould
    {
        private readonly Beer _beer;

        public BeerShould() =>
                _beer = new Beer
                {
                    Id = 1,
                    Name = "TestBeer",
                    IsFavorite = true
                };

        [Fact]
        public void Construct() =>
            _beer.Should().BeOfType<Beer>();
    }
}