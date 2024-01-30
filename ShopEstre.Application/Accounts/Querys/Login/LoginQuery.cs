using MediatR;
using ShopEstre.Application.Common.Dtos;

namespace ShopEstre.Application.Accounts.Querys.Login
{
    public class LoginQuery : IRequest<ResponseCustom<string>>
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool RememberMe {  get; set; }
    }
}
