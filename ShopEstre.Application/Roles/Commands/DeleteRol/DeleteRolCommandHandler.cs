using MediatR;
using ShopEstre.Application.Common.Dtos;
using ShopEstre.Domain.Interfaces.Repositories;

namespace ShopEstre.Application.Roles.Commands.DeleteRol
{
    public class DeleteRolCommandHandler : IRequestHandler<DeleteRolCommand, ResponseCustom<string>>
    {
        private readonly IRoleRepository _roleRepository;
        public DeleteRolCommandHandler(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public async Task<ResponseCustom<string>> Handle(DeleteRolCommand request, CancellationToken cancellationToken)
        {
            if (! await _roleRepository.Exits(new Guid(request.RolId))) throw new KeyNotFoundException("Rol no existente!");
            await _roleRepository.Delete(request.RolId);
            return new ResponseCustom<string>("Rol Eliminado!", 200, "Success");
        }
    }
}
