using ShopEstre.Domain.Dtos.Rols;

namespace SportStre.Test.UnitTest.Rols.Entities
{
    public class RolDtoTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RolDtoContructorTest()
        {
            var rol = new RolDto() { Name = "Luis", Description = "El Super", RolId = Guid.NewGuid() };
            Assert.IsNotNull(rol);
            Assert.IsNotEmpty(rol.RolId.ToString());
            Assert.IsNotNull(rol.Name);
            Assert.IsNotNull(rol.Description);
            Assert.AreEqual("Luis", rol.Name);
            Assert.AreEqual("El Super", rol.Description);
            Assert.That("El Super", Is.EqualTo(rol.Description));

        }
    }
}
