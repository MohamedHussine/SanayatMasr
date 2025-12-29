namespace Entities.Models
{
    public class RevokedToken : BaseModel
    {
        public string Token { get; set; } = string.Empty;
        public DateTime Expiration { get; set; }
    }
}
