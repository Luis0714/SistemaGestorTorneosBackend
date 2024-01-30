using MediatR;
using ShopEstre.Application.Common.Dtos;
using ShopEstre.Domain.Interfaces.Repositories;
using ShopEstre.Domain.Interfaces.Sercurity.Authorization;
using System.Security.Claims;

namespace ShopEstre.Application.Accounts.Querys.AutheticateWithGoogle
{
    public class AuthenticateUserWithGoogleQueryHandler : IRequestHandler<AuthenticateUserWithGoogleQuery, ResponseCustom<string>>
    {
        private readonly IJwtService _jwtService;
        private readonly IUserRepository _userRepository;
        public AuthenticateUserWithGoogleQueryHandler(IJwtService jwtService, IUserRepository userRepository)
        {
            _jwtService = jwtService;
            _userRepository = userRepository;
        }
        public async Task<ResponseCustom<string>> Handle(AuthenticateUserWithGoogleQuery request, CancellationToken cancellationToken)
        {
            var userIdentity = request.HttpContext.User.Identity as ClaimsIdentity;
            var userGoogle = _jwtService.ValidatedGoogleToken(userIdentity!);
            var userDataBase = await _userRepository.GetByEmail(userGoogle.Email);
            if (userDataBase == null)
                return new ResponseCustom<string>("No autorizado!", 401);
            var token = _jwtService.GenerateToken(userDataBase);
            return new ResponseCustom<string>("Token", 200, token);

        }
    }
}
