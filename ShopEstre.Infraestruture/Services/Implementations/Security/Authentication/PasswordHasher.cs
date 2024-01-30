using ShopEstre.Domain.Interfaces.Sercurity.Authentication;
using ShopEstre.Domain.ValueObjects;

namespace ShopEstre.Infraestruture.Services.Implementations.Security.Authentication
{
    internal class PasswordHasher : IPasswordHasher
    {
        public void EncryptPassword(Password password) { password.Value = EncryptPassword(password.Value); }
        public string EncryptPassword(string password) => BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt());
        public bool VerifyPassword(string hashedPassword, string providedPassword) => BCrypt.Net.BCrypt.Verify(providedPassword, hashedPassword);
    }
}
