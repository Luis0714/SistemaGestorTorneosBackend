using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShopEstre.Domain.Interfaces.Sercurity.Authentication;

namespace ShopEstre.API.Controllers.v1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        private readonly IMediator? _mediator;
        protected IMediator Mediator => _mediator ?? HttpContext.RequestServices.GetService<IMediator>()!;

    }
}
