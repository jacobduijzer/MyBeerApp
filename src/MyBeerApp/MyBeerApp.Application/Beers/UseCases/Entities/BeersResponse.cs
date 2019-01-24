using MyBeerApp.Domain.Beers;
using System.Collections.Generic;

namespace MyBeerApp.Application.Beers.UseCases.Entities
{
    public class BeersResponse
    {
        public readonly List<Beer> Beers;

        public BeersResponse(List<Beer> beers) =>
            Beers = beers;
    }
}