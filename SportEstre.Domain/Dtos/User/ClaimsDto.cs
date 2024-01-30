using System.Security.Claims;

namespace ShopEstre.Domain.Dtos.User
{
    public class ClaimsDto
    {
        [Claim("UserId")]
        public Guid UserId { get; set; }

        [Claim("RoleId")]
        public Guid RolId { get; set; }
    }
}
