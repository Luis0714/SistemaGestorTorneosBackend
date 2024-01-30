using MediatR;
using Microsoft.AspNetCore.Http;
using ShopEstre.Application.Common.Dtos;
using ShopEstre.Domain.Dtos.User;

namespace ShopEstre.Application.Accounts.Querys.Authenticate
{
    public class AuthenticateUserQuery : IRequest<ResponseCustom<UserDto>>
    {
        public HttpContext HttpContext { get; set; }

        public AuthenticateUserQuery(HttpContext httpContext)
        {
            HttpContext = httpContext;
        }
    }
}
