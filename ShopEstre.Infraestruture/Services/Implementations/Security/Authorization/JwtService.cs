using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ShopEstre.Application.Common.Dtos.Authorization;
using ShopEstre.Domain.Dtos.User;
using ShopEstre.Domain.Entities;
using ShopEstre.Domain.Interfaces.Sercurity.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ShopEstre.Infraestruture.Services.Implementations.Security.Authorization
{
    public class JwtService : IJwtService
    {
        private readonly IConfiguration _configuration;
        public JwtService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GenerateToken(User user)
        {
            var jwt = _configuration.GetSection("Jwt").Get<JwtDto>();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key));
            var credenciales = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var claims = getClaims(user, jwt);
            var timeExpires = DateTime.Now.AddHours(1);

            if (jwt == default)
                throw new ArgumentException(nameof(jwt));

            var securityToken = new JwtSecurityToken(jwt.Issuer, jwt.Audience, claims, expires: timeExpires, signingCredentials: credenciales);

            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }

        public UserDto ValidatedToken(ClaimsIdentity claimsIdentity)
        {
            var claims = claimsIdentity.Claims;
            var user = new UserDto
            {
                UserId = new Guid(claims.FirstOrDefault(claim => claim.Type == "UserId")?.Value!),
                Name = claims.FirstOrDefault(claim => claim.Type == ClaimTypes.NameIdentifier)?.Value!,
                Email = claims.FirstOrDefault(claim => claim.Type == ClaimTypes.Email)?.Value!,
                LastName = claims.FirstOrDefault(claim => claim.Type == ClaimTypes.GivenName!)?.Value!,
                Rol = claims.FirstOrDefault(claim => claim.Type == ClaimTypes.Role)?.Value!,
                PhoneNumber = claims.FirstOrDefault(claim => claim.Type == "PhoneNumber")?.Value!

            };
            return user;
        }

        private Claim[] getClaims(User user, JwtDto jwt)
        {
            return new[]
            {
                    new Claim(ClaimTypes.NameIdentifier,user.Name),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.GivenName, user.Name),
                    new Claim(ClaimTypes.Surname, user.LastName),
                    new Claim(ClaimTypes.Role, user.RoleId.ToString()),
                    new Claim("UserId", user.UserId.ToString()),
                    new Claim("RoleId", user.RoleId.ToString()),
                    new Claim("PhoneNumber", user.PhoneNumber.Value)
            };
        }

        public UserGoogleDto ValidatedGoogleToken(ClaimsIdentity claimsIdentity)
        {
            var claims = claimsIdentity.Claims;
            return new UserGoogleDto()
            {
                Name = claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)!.Value,
                Email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)!.Value
            };
        }

    }
}
