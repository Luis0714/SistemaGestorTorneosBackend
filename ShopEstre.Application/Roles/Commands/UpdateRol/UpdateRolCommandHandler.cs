using AutoMapper;
using MediatR;
using ShopEstre.Application.Common.Dtos;
using ShopEstre.Domain.Dtos.Rols;
using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Repositories;

namespace ShopEstre.Application.Roles.Commands.UpdateRol
{
    public class UpdateRolCommandHandler : IRequestHandler<UpdateRolCommand, ResponseCustom<RolDto>>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        public UpdateRolCommandHandler(IRoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task<ResponseCustom<RolDto>> Handle(UpdateRolCommand request, CancellationToken cancellationToken)
        {
            if (!await _roleRepository.Exits(new Guid(request.RolId))) throw new KeyNotFoundException("Rol no existente!");
            var role = _mapper.Map<Role>(request);
            var response = await _roleRepository.Update(role);
            var rolDto = _mapper.Map<RolDto>(response);
            return new ResponseCustom<RolDto>("Rol Editado!", 200, rolDto);
        }
    }
}
