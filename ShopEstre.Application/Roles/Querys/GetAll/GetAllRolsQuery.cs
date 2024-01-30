using MediatR;
using ShopEstre.Application.Common.Dtos;
using ShopEstre.Domain.Dtos.Rols;

namespace ShopEstre.Application.Roles.Querys.GetAll
{
    public class GetAllRolsQuery : IRequest<ResponseCustom<List<RolDto>>>
    {
    }
}
