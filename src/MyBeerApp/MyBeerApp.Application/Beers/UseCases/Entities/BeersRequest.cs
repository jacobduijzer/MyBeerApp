using LinqBuilder.Core;
using MediatR;
using MyBeerApp.Domain.Beers;

namespace MyBeerApp.Application.Beers.UseCases.Entities
{
    public class BeersRequest : IRequest<BeersResponse>
    {
        public readonly ISpecification<Beer> Specification;

        public BeersRequest(ISpecification<Beer> specification) =>
            Specification = specification;
    }
}