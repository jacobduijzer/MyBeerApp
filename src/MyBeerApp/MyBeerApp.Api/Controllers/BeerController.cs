using Microsoft.AspNetCore.Mvc;
using MyBeerApp.Application.Beers.Specifications;
using MyBeerApp.Application.Beers.UseCases.Entities;
using MyBeerApp.Domain.Beers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyBeerApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : BaseController
    {
        public BeerController(MediatR.IMediator mediator)
            : base(mediator)
        { }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Beer>>> Get()
        {
            var response = await Mediator.Send(new BeersRequest(new AllBeers())).ConfigureAwait(false);
            return response.Beers;
        }
    }
}