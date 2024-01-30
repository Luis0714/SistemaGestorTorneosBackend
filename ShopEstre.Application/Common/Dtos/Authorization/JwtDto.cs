namespace ShopEstre.Application.Common.Dtos.Authorization
{
    public class JwtDto
    {
        public string Key { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
    }
}
