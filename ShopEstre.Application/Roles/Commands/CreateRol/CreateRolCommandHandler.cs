using AutoMapper;
using MediatR;
using ShopEstre.Application.Common.Dtos;
using ShopEstre.Domain.Dtos.Rols;
using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Domain.Interfaces.Sercurity.Authentication;

namespace ShopEstre.Application.Roles.Commands.CreateRol
{
    public class CreateRolCommandHandler : IRequestHandler<CreateRolCommand, ResponseCustom<RolDto>>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        private readonly IRequestService _requestService;
        public CreateRolCommandHandler(IRoleRepository roleRepository, IMapper mapper, IRequestService requestService)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
            _requestService = requestService;
        }

        public async Task<ResponseCustom<RolDto>> Handle(CreateRolCommand request, CancellationToken cancellationToken)
        {
            if (await _roleRepository.Exits(request.Name)) return new ResponseCustom<RolDto>("Rol Existenete!", 400);
            var role = new Role(request.Name, request.Description);
            var roleCreated = await _roleRepository.Create(role);
            var rolDto = _mapper.Map<RolDto>(roleCreated);
            return new ResponseCustom<RolDto>("Rol creado con exito!", 200, rolDto);
        }
    }
}
