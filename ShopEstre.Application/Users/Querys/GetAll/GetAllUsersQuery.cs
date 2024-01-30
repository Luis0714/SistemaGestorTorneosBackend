using MediatR;
using ShopEstre.Application.Common.Dtos.Users;

namespace ShopEstre.Application.Users.Querys.GetAll
{
    public class GetAllUsersQuery : IRequest<List<UserDto>>{}
}
