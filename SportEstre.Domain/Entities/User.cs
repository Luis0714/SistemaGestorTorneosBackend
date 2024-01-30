using ShopEstre.Domain.ValueObjects;

namespace ShopEstre.Domain.Entities
{
    public class User
    {
        public Guid UserId { get; set; } 
        public Guid RoleId { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string LastName {  get; set; } = string.Empty;
        public PhoneNumber PhoneNumber { get; set; }
        public string Email { get; set; } = string.Empty;
        public Password Password { get; set; }
        public Role Role { get; set; }
        public Player Player { get; set; }

        public User(string name, string lastName, PhoneNumber phoneNumber, string email, Password password, Role rol, Player player)
        {
            UserId = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            Password = password;
            Role = rol;
            Player = player;
        }

        public User()
        {
            UserId = Guid.NewGuid();
        }

    }
}
