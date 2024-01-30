using MediatR;
using ShopEstre.Application.Common.Dtos;
using ShopEstre.Domain.Dtos.Rols;

namespace ShopEstre.Application.Roles.Commands.UpdateRol
{
    public class UpdateRolCommand : IRequest<ResponseCustom<RolDto>>
    {
        public string RolId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
