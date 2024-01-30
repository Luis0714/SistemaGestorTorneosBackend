using ShopEstre.Domain.Dtos.User;
using ShopEstre.Domain.Entities;
using System.Security.Claims;


namespace ShopEstre.Domain.Interfaces.Sercurity.Authorization
{
    public interface IJwtService
    {
        string GenerateToken(User user);
        UserDto ValidatedToken(ClaimsIdentity claimsIdentity);
        UserGoogleDto ValidatedGoogleToken(ClaimsIdentity claimsIdentity);
        
    }
}
