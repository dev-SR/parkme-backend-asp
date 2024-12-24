namespace Shared.DTO.Auth;

public record LoginResponseDto
{
    public required string AccessToken { get; init; }
    public required string RefreshToken { get; init; }
    public required UserResponseDto User { get; init; }
}


// public class Class
// {
//     public Class()
//     {
//         LoginResponseDto loginRequest = new()
//         {
//             AccessToken = "user@example.com",
//             RefreshToken = "securepassword123",
//             user = new UserResponseDto
//             {
//                 Id = "123",
//                 Email = "jhon@gmail.com",
//                 Roles = new List<string> { "Admin", "User" }
//             }
//         };
//     }
// }