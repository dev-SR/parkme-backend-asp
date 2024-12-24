namespace Domain.Contracts;
public interface IRepositoryManager
{
    IRefreshTokenRepository RefreshToken { get; }
    Task SaveAsync();
}