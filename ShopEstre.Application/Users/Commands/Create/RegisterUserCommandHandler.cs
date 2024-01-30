using AutoMapper;
using MediatR;
using ShopEstre.Application.Common.Dtos;
using ShopEstre.Application.Common.Dtos.Users;
using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Domain.Interfaces.Sercurity.Authentication;
using ShopEstre.Domain.ValueObjects;

namespace ShopEstre.Application.Users.Commands.Create
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, ResponseCustom<UserDto>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        public RegisterUserCommandHandler(IUserRepository userRepository, IPasswordHasher passwordHasher, IRoleRepository roleRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            _roleRepository = roleRepository;
            _mapper = mapper;
        }
        public async Task<ResponseCustom<UserDto>> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
           
            var password = Password.Create(request.Password)!;
            var phoneNumber = PhoneNumber.Create(request.PhoneNumber);
            var role = await _roleRepository.GetById(request.RoleId);
            _passwordHasher.EncryptPassword(password);

            if (role == default)
                return new ResponseCustom<UserDto>("Rol no existente!", 400);

            var user = new User(request.Name, request.LastName, phoneNumber!, request.Email, password, role, null);

            if (await _userRepository.Exits(user)) return new ResponseCustom<UserDto>(message: "Usuario Existente!", status: 400);

            var userCreated = await _userRepository.Create(user);

            var response = _mapper.Map<UserDto>(userCreated);
            response.PhoneNumber = userCreated.PhoneNumber.Value;

           return new ResponseCustom<UserDto>(message: "Usuario Creado Exitosamente!", status: 200, data: response);
        }
    }
}
