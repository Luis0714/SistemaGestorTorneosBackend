using MediatR;
using ShopEstre.Application.Common.Dtos;
using ShopEstre.Domain.Dtos.User;
using ShopEstre.Domain.Interfaces.Sercurity.Authentication;
using ShopEstre.Domain.Interfaces.Sercurity.Authorization;
using System.Security.Claims;

namespace ShopEstre.Application.Accounts.Querys.Authenticate
{
    public class AuthenticateUserQueryHandler : IRequestHandler<AuthenticateUserQuery, ResponseCustom<UserDto>>
    {
        private readonly IJwtService _jwtService;
        private readonly IRequestService _requestService;
        public AuthenticateUserQueryHandler(IJwtService jwtService, IRequestService requestService)
        {
            _jwtService = jwtService;
            _requestService = requestService;
        }
        public async Task<ResponseCustom<UserDto>> Handle(AuthenticateUserQuery request, CancellationToken cancellationToken)
        {
            var userIdentity = request.HttpContext.User.Identity as ClaimsIdentity;
            _requestService.SetClaims(userIdentity!.Claims);
            if (userIdentity == default) throw new ArgumentNullException(nameof(userIdentity));

            var user = _jwtService.ValidatedToken(userIdentity);
            if (user == null) throw new ArgumentNullException(nameof(user));

            return new ResponseCustom<UserDto>("Perfil usuario!", 200, user);
        }
    }
}
