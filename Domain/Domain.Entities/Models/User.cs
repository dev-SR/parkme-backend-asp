using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.Models;

public class MyUser : IdentityUser<Guid>
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public virtual RefreshToken? RefreshToken { get; set; }

    public virtual List<Booking>? Bookings { get; set; } = [];
}


public class MyRole : IdentityRole<Guid> // Ensure it matches the key type
{
    // Add any custom properties if needed
}
