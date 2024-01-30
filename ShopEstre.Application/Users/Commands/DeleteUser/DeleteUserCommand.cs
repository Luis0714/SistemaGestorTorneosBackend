using MediatR;
using ShopEstre.Application.Common.Dtos;

namespace ShopEstre.Application.Users.Commands.DeleteUser
{
    public class DeleteUserCommand : IRequest<ResponseCustom<string>>
    {
        public string UserId { get; set; }
    }
}
