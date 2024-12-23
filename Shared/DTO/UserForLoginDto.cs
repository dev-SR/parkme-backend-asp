using System.ComponentModel.DataAnnotations;

namespace Shared.DTO;

public record class UserForLoginDto
{
    [Required(ErrorMessage = "User name is required")]
    public required string Email { get; init; }
    [Required(ErrorMessage = "Password name is required")]
    public required string Password { get; init; }
}
