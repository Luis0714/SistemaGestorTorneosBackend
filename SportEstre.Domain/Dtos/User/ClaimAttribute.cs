namespace ShopEstre.Domain.Dtos.User
{
    public class ClaimAttribute : Attribute
    {
        public string KeyName { get; private set; }

        public ClaimAttribute()
        {
            KeyName = null;
        }
        public ClaimAttribute(string keyName)
        {
            KeyName = keyName;
        }
    }
}
