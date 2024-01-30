using ShopEstre.Domain.Dtos.User;

namespace SportStre.Test.UnitTest.Users.Entities
{
    public class UserDtoTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void UserDtoContructorTest()
        {
            var user = new UserDto()
            {
                UserId = Guid.NewGuid(),
                Name = "Test",
                LastName = "Test",
                Email = "test@mail.com",
                PhoneNumber = "3023776136",
                Rol = Guid.NewGuid().ToString()
            };

            Assert.IsNotNull(user);
            Assert.IsNotNull(user.UserId); 
            Assert.IsNotNull(user.Name);
            Assert.IsNotNull(user.LastName);
            Assert.IsNotNull(user.Email);
            Assert.IsNotNull(user.PhoneNumber);
            Assert.IsNotNull(user.Rol);
        }
    }
}
