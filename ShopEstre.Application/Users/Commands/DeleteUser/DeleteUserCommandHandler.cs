using AutoMapper;
using MediatR;
using ShopEstre.Application.Common.Dtos;
using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Repositories;

namespace ShopEstre.Application.Users.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, ResponseCustom<string>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public DeleteUserCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<ResponseCustom<string>> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            if (!await _userRepository.Exits(request.UserId)) throw new KeyNotFoundException("Usuario no existe!");
            await _userRepository.Delete(request.UserId);
            return new ResponseCustom<string>("Usuario Eliminado!", 200, "Success");
        }
    }
}
