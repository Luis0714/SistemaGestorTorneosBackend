using ShopEstre.Domain.Dtos.Rols;
using ShopEstre.Domain.Entities;

namespace ShopEstre.Application.Common.Dtos.Users
{
    public class UserDto
    {
        public Guid UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public  RolDto Role { get; set; }

    }
}
