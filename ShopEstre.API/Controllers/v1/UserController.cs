using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopEstre.Application.Users.Commands.Create;
using ShopEstre.Application.Users.Commands.DeleteUser;
using ShopEstre.Application.Users.Commands.UpdateUser;
using ShopEstre.Application.Users.Querys.GetAll;
using ShopEstre.Domain.Interfaces.Sercurity.Authentication;

namespace ShopEstre.API.Controllers.v1
{
    [ApiVersion("1.0")]
    public class UserController : BaseApiController
    {

        [HttpPost("registerUser")]
        public async Task<IActionResult> RegisterUser(RegisterUserCommand command) => Ok(await Mediator.Send(command));

        [Authorize]
        [HttpDelete("deleteUser/{userId}")]
        public async Task<IActionResult> DeleteUser(string userId) => Ok(await Mediator.Send(new DeleteUserCommand() { UserId = userId }));

        [Authorize]
        [HttpGet("getAllUsers")]
        public async Task<IActionResult> GetAllUsers() => Ok(await Mediator.Send(new GetAllUsersQuery()));

        [Authorize]
        [HttpPut("updateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserCommand command) => Ok(await Mediator.Send(command));
    }
}
