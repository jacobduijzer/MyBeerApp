using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBeerApp.Application.Beers.Specifications;
using MyBeerApp.Application.Beers.UseCases.Entities;
using MyBeerApp.Domain.Beers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBeerApp.Web.Pages
{
    public class BeersModel : PageModel
    {
        private readonly IMediator _mediator;

        public BeersModel(IMediator mediator) =>
            _mediator = mediator;

        public List<Beer> Beers { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var response = await _mediator.Send(new BeersRequest(new AllBeers())).ConfigureAwait(false);
            if (response != null && response.Beers != null && response.Beers.Any())
                Beers = response.Beers;

            return Page();
        }
    }
}