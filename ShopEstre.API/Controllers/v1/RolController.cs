using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopEstre.Application.Roles.Commands.CreateRol;
using ShopEstre.Application.Roles.Commands.DeleteRol;
using ShopEstre.Application.Roles.Commands.UpdateRol;
using ShopEstre.Application.Roles.Querys.GetAll;

namespace ShopEstre.API.Controllers.v1
{
    [ApiVersion("1.0")]
    public class RolController : BaseApiController
    {
    
        [HttpPost("createRol")]
        public async Task<IActionResult> CreateRol([FromBody] CreateRolCommand command) => Ok(await Mediator.Send(command));

        [Authorize]
        [HttpGet("getAllRols")]
        public async Task<IActionResult> GetAllRols() => Ok(await Mediator.Send(new GetAllRolsQuery()));

        [Authorize]
        [HttpPut("updateRol")]
        public async Task<IActionResult> UpdateRol([FromBody] UpdateRolCommand command) => Ok(await Mediator.Send(command));

        [Authorize]
        [HttpDelete("deleteRol/{rolId}")]
        public async Task<IActionResult> DeleteTol(string rolId) => Ok(await Mediator.Send(new DeleteRolCommand() { RolId = rolId}));
    }
}
