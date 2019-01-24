using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MyBeerApp.Api.Controllers
{
    public class BaseController : ControllerBase
    {
        protected readonly IMediator Mediator;

        public BaseController(IMediator mediator) =>
            Mediator = mediator;
    }
}