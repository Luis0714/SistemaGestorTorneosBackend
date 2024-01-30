using MediatR;
using ShopEstre.Application.Common.Dtos;
using ShopEstre.Application.Common.Dtos.Users;

namespace ShopEstre.Application.Users.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest<ResponseCustom<UserDto>>
    {
        public string UserId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string RoleId { get; set; } = string.Empty;
    }
}
