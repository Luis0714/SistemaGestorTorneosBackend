using ShopEstre.Domain.ValueObjects;

namespace ShopEstre.Domain.Interfaces.Sercurity.Authentication
{
    public interface IPasswordHasher
    {
        void EncryptPassword(Password password);
        string EncryptPassword(string password);
        bool VerifyPassword(string hashedPassword,string providedPassword);
    }
}
