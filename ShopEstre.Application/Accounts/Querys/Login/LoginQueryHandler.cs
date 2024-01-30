using MediatR;
using ShopEstre.Application.Common.Dtos;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Domain.Interfaces.Sercurity.Authentication;
using ShopEstre.Domain.Interfaces.Sercurity.Authorization;

namespace ShopEstre.Application.Accounts.Querys.Login
{
    public class LoginQueryHandler : IRequestHandler<LoginQuery, ResponseCustom<string>>
    {
        private readonly IJwtService _jwtService;
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;
        public LoginQueryHandler(IJwtService jwtService, IUserRepository userRepository, IPasswordHasher passwordHasher = null)
        {
            _jwtService = jwtService;
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
        }
        public async Task<ResponseCustom<string>> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByEmail(request.Email);
            if (user != default)
                if (_passwordHasher.VerifyPassword(user.Password.Value, request.Password))
                    return new ResponseCustom<string>("Token", 200, _jwtService.GenerateToken(user));
            return new ResponseCustom<string>("Credenciales invalidas!", 400, "");
        }
    }
}
