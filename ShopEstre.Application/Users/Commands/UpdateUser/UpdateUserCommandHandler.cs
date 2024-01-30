using AutoMapper;
using MediatR;
using ShopEstre.Application.Common.Dtos;
using ShopEstre.Application.Common.Dtos.Users;
using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Domain.ValueObjects;

namespace ShopEstre.Application.Users.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, ResponseCustom<UserDto>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        public UpdateUserCommandHandler(IUserRepository userRepository, IMapper mapper, IRoleRepository roleRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _roleRepository = roleRepository;
        }
        public async Task<ResponseCustom<UserDto>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            if (!await _userRepository.Exits(request.UserId)) throw new KeyNotFoundException("Usuario no existe!");
            var userdb = await _userRepository.GetById(request.UserId);
            userdb.PhoneNumber = PhoneNumber.Create(request.PhoneNumber);
            userdb.Email = request.Email;
            userdb.Name = request.Name;
            userdb.LastName = request.LastName;
            userdb.Role = await _roleRepository.GetById(request.RoleId);
            var userCreated = await _userRepository.Update(userdb);
            var response = _mapper.Map<UserDto>(userCreated);
            response.PhoneNumber = userCreated.PhoneNumber.Value;
            return new ResponseCustom<UserDto>("Usuario Actualizado!", 200, response);
        }
    }
}
