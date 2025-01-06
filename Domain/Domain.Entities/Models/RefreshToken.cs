namespace Domain.Entities.Models;
public class RefreshToken
{
    public required string Token { get; set; }
    public required DateTime ExpiryDate { get; set; }
    public bool IsRevoked { get; set; } = false; // Revocation status
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;
    public bool IsExpired => DateTime.UtcNow >= ExpiryDate; // Expiry check
    public required Guid UserId { get; set; }
    public virtual MyUser User { get; set; } = null!; //null-forgiving

}
