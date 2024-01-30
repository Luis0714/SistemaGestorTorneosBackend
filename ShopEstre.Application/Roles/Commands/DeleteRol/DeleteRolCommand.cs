using MediatR;
using ShopEstre.Application.Common.Dtos;

namespace ShopEstre.Application.Roles.Commands.DeleteRol
{
    public class DeleteRolCommand : IRequest<ResponseCustom<string>>
    {
        public string RolId { get; set; } = string.Empty;
    }
}
