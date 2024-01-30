using MediatR;
using ShopEstre.Application.Common.Dtos;
using ShopEstre.Domain.Dtos.Rols;

namespace ShopEstre.Application.Roles.Commands.CreateRol
{
    public class CreateRolCommand : IRequest<ResponseCustom<RolDto>>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
