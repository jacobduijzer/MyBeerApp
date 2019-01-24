using MyBeerApp.Domain.Beers;
using System.Collections.Generic;

namespace MyBeerApp.Mocks.Beers
{
    public static class BeerData
    {
        public static List<Beer> Beers => new List<Beer>
        {
            new Beer { Id = 1, Name = "Test beer 1", IsFavorite = true },
            new Beer { Id = 2, Name = "Test beer 2" }
        };
    }
}