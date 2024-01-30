namespace ShopEstre.Domain.Entities
{
    public class Role
    {
        public Guid RolId { get; set; }
        public string Name { get; set; } = string.Empty; 
        public string Description { get; set;} = string.Empty;
        public List<User> Users { get; set; }
        public Role(string name, string description) 
        {
            RolId = Guid.NewGuid();
            Name = name;
            Description = description;
            Users = new List<User>();
        }

        public Role()
        {
            RolId = Guid.NewGuid(); 
            Users = new List<User>();
        }
    }
}
