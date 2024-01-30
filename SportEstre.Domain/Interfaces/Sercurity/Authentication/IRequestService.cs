using ShopEstre.Domain.Dtos.User;
using System.Security.Claims;

namespace ShopEstre.Domain.Interfaces.Sercurity.Authentication
{
    public interface IRequestService
    {
        ClaimsDto Claims { get; set; }
        void SetClaims(IEnumerable<Claim> claims);
    }
}
