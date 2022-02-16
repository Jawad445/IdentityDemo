namespace IdentityDemo.API.Models
{
    public class AuthSettings
    {
        public string Key { get; set; }
        public string Audiance { get; set; }
        public string Issuer { get; set; }
        public int TokenValidityInMinutes { get; set; }
        public int RefreshTokenValidityInDays { get; set; }
    }
}
