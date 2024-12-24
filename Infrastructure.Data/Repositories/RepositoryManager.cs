
using Domain.Contracts;

namespace Infrastructure.Data.Repositories;

public class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryDbContext _dbContext;
    private readonly Lazy<IRefreshTokenRepository> _refreshTokenRepository;

    public RepositoryManager(RepositoryDbContext dbContext)
    {
        _dbContext = dbContext;
        _refreshTokenRepository = new Lazy<IRefreshTokenRepository>(() => new RefreshTokenRepository(dbContext));

    }
    public IRefreshTokenRepository RefreshToken => _refreshTokenRepository.Value;
    public async Task SaveAsync() => await _dbContext.SaveChangesAsync();
}
