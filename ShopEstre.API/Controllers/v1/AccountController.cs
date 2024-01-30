using Asp.Versioning;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopEstre.Application.Accounts.Querys.Authenticate;
using ShopEstre.Application.Accounts.Querys.AutheticateWithGoogle;
using ShopEstre.Application.Accounts.Querys.Login;
using ShopEstre.Domain.Interfaces.Sercurity.Authentication;

namespace ShopEstre.API.Controllers.v1
{
    [ApiVersion("1.0")]
    public class AccountController : BaseApiController
    {

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginQuery credentials) => Ok(await Mediator.Send(credentials));

        [Authorize]
        [HttpGet("authenticate")]
        public async Task<IActionResult> Autenticate() => Ok(await Mediator.Send(new AuthenticateUserQuery(HttpContext)));

        [Authorize(AuthenticationSchemes = GoogleDefaults.AuthenticationScheme)]
        [HttpPost("authenticateWithGoogle")]
        public async Task<IActionResult> AuthenticateWithGoogle()
            => Ok(await Mediator.Send( new AuthenticateUserWithGoogleQuery(HttpContext)));

    }
}
