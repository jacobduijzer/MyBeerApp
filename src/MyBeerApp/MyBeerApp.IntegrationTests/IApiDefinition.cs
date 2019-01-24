using MyBeerApp.Domain.Beers;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyBeerApp.IntegrationTests
{
    public interface IApiDefinition
    {
        [Get("/api/beer")]
        Task<List<Beer>> GetAllBeers();
    }
}