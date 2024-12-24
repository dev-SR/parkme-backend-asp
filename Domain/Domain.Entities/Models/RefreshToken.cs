namespace Domain.Entities.Models;

public class RefreshToken
{
    public required string Token { get; set; }
    public required DateTime ExpiryDate { get; set; }
    public bool IsRevoked { get; set; } = false; // Revocation status
    public required string UserId { get; set; }
    public User User { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;
    public bool IsExpired => DateTime.UtcNow >= ExpiryDate; // Expiry check

}
