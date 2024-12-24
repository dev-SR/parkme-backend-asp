using System;

namespace Shared.DTO.Auth;

public record UserResponseDto
{
    public required string Id { get; init; }
    public required string Email { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required ICollection<string> Roles { get; init; }
}