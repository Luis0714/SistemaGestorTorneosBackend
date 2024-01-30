using ShopEstre.Domain.Entities;

namespace SportStre.Test.UnitTest.Rols.Entities
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RolContructorTest()
        {
            var rol = new Role("Jefe", "El Jefe");

            Assert.IsNotNull(rol);
            Assert.IsNotEmpty(rol.RolId.ToString());
            Assert.IsNotNull(rol.Name);
            Assert.IsNotNull(rol.Description);
            Assert.AreEqual("Jefe", rol.Name);
            Assert.AreEqual("El Jefe", rol.Description);
            Assert.That("El Jefe", Is.EqualTo(rol.Description));
            Assert.IsNotNull(rol.Users);
        }

        [Test]
        public void RolConstructorEmtyTest()
        {
            var rol = new Role();
            Assert.IsNotNull(rol);
            Assert.IsNotEmpty(rol.RolId.ToString());
            Assert.IsNotNull(rol.Users);
        }
    }
}