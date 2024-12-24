namespace Shared.DTO;

public record TokenDto(string AccessToken, string RefreshToken);
public record RefreshDto(string refreshToken);
