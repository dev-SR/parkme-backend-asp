namespace Shared.DTO.Auth;
public record TokenPairDto(string AccessToken, string RefreshToken);
public record RefreshTokenRequestDto(string refreshToken);
