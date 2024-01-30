using AutoMapper;
using MediatR;
using ShopEstre.Application.Common.Dtos;
using ShopEstre.Domain.Dtos.Rols;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Domain.Interfaces.Sercurity.Authentication;

namespace ShopEstre.Application.Roles.Querys.GetAll
{
    public class GetAllRolsQueryHandler : IRequestHandler<GetAllRolsQuery, ResponseCustom<List<RolDto>>>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        private readonly IRequestService _requestService;
        public GetAllRolsQueryHandler(IRoleRepository roleRepository, IMapper mapper, IRequestService requestService)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
            _requestService = requestService;
        }
        public async Task<ResponseCustom<List<RolDto>>> Handle(GetAllRolsQuery request, CancellationToken cancellationToken)
        {
            var rols = _roleRepository.GetAll();
            var rolsDto = _mapper.Map<List<RolDto>>(rols);
            return new ResponseCustom<List<RolDto>>("Lista de roles!", 200, rolsDto);
        }
    }
}
