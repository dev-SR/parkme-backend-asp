using System.ComponentModel.DataAnnotations;

namespace Shared.DTO.Auth;

public record class LoginRequestDto
{
    [Required(ErrorMessage = "User name is required")]
    public required string Email { get; init; }
    [Required(ErrorMessage = "Password name is required")]
    public required string Password { get; init; }
};

