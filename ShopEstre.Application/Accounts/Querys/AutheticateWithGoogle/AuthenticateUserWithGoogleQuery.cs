using MediatR;
using Microsoft.AspNetCore.Http;
using ShopEstre.Application.Common.Dtos;

namespace ShopEstre.Application.Accounts.Querys.AutheticateWithGoogle
{
    public class AuthenticateUserWithGoogleQuery : IRequest<ResponseCustom<string>>
    {
        public HttpContext HttpContext { get; set; }

        public AuthenticateUserWithGoogleQuery(HttpContext httpContext)
        {
            HttpContext = httpContext;
        }
    }
}
