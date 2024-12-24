using System;
using System.ComponentModel.DataAnnotations;

namespace Shared.DTO.Auth;

public record RegistrationRequestDto
{
    [Required(ErrorMessage = "First Name is required")]
    public required string FirstName { get; init; }
    [Required(ErrorMessage = "Last Name is required")]
    public required string LastName { get; init; }
    [Required(ErrorMessage = "Password is required")]
    public required string Password { get; init; }
    [Required(ErrorMessage = "Username is required")]
    public required string Email { get; init; }
    // public ICollection<string>? Roles { get; init; }
}