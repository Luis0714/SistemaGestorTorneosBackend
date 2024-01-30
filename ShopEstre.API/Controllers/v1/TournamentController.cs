using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using ShopEstre.Domain.Interfaces.Sercurity.Authentication;

namespace ShopEstre.API.Controllers.v1
{
    [ApiVersion("1.0")]
    public class TournamentController : BaseApiController
    {

        [HttpGet("Hello/{name}")]
        public IActionResult Hello(string name)
        {
            var response = new { message = "Bienvenido "+name+"Como vas?" };
            return Ok(response);
        }
    }
}
