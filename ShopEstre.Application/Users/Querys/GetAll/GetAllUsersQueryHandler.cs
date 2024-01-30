using AutoMapper;
using MediatR;
using ShopEstre.Application.Common.Dtos.Users;
using ShopEstre.Domain.Dtos.Rols;
using ShopEstre.Domain.Interfaces.Repositories;

namespace ShopEstre.Application.Users.Querys.GetAll
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserDto>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public GetAllUsersQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = _userRepository.GetAll();
            return users.Select(user => new UserDto()
            {
                UserId = user.UserId,
                Name = user.Name,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber.Value,
                LastName = user.LastName,
                Role = _mapper.Map<RolDto>(user.Role)
            }).ToList();
        }
    }
}
