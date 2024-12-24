using System;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.Models;

public class User : IdentityUser
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public RefreshToken? RefreshToken { get; set; }
}