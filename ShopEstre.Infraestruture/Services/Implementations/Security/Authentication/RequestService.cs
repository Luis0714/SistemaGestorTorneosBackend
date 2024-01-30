using ShopEstre.Domain.Dtos.User;
using ShopEstre.Domain.Interfaces.Sercurity.Authentication;
using System.Reflection;
using System.Security.Claims;

namespace ShopEstre.Infraestruture.Services.Implementations.Security.Authentication
{
    internal class RequestService : IRequestService
    {
        public ClaimsDto Claims { get; set; }

        public void SetClaims(IEnumerable<Claim> claims)
        {
            var claimsDto = new ClaimsDto();
            foreach (var property in claimsDto.GetType().GetProperties())
            {
                var claimKey = property.GetCustomAttribute<ClaimAttribute>()!.KeyName;
                var value = claims.FirstOrDefault(claim => claim.Type == claimKey);
                if (!string.IsNullOrEmpty(value?.Value))
                    property.SetValue(claimsDto, new Guid(value?.Value));
            }
            Claims = claimsDto;
        }
    }
}
