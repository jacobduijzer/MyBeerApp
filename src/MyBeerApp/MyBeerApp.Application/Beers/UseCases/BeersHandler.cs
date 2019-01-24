using MediatR;
using MyBeerApp.Application.Beers.UseCases.Entities;
using MyBeerApp.Application.Shared;
using MyBeerApp.Domain.Beers;
using MyBeerApp.Domain.Shared;
using System.Threading;
using System.Threading.Tasks;

namespace MyBeerApp.Application.Beers.UseCases
{
    public class BeersHandler : HandlerBase<Beer>, IRequestHandler<BeersRequest, BeersResponse>
    {
        public BeersHandler(IRepository<Beer> beerRepository)
            : base(beerRepository)
        { }

        public async Task<BeersResponse> Handle(BeersRequest request, CancellationToken cancellationToken)
        {
            var results = await Repository.GetItemsAsync(request.Specification).ConfigureAwait(false);
            var response = new BeersResponse(results);

            return await Task.FromResult(response);
        }
    }
}