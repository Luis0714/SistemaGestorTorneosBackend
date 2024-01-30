using MediatR;
using ShopEstre.Application.Common.Dtos;
using ShopEstre.Application.Common.Dtos.Users;

namespace ShopEstre.Application.Users.Commands.Create
{
    public class RegisterUserCommand : IRequest<ResponseCustom<UserDto>>
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string RoleId { get; set; } = string.Empty;
    }
}
