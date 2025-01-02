
using Domain.Contracts;

namespace Infrastructure.Data.Repositories;

public class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryDbContext _dbContext;
    private readonly Lazy<IRefreshTokenRepository> _refreshTokenRepository;
    private readonly Lazy<IParkingLotRepository> _parkingLotRepository;

    public RepositoryManager(RepositoryDbContext dbContext)
    {
        _dbContext = dbContext;
        _refreshTokenRepository = new Lazy<IRefreshTokenRepository>(() => new RefreshTokenRepository(dbContext));
        _parkingLotRepository = new Lazy<IParkingLotRepository>(() => new ParkingLotRepository(dbContext));

    }
    public IRefreshTokenRepository RefreshToken => _refreshTokenRepository.Value;
    public IParkingLotRepository ParkingLot => _parkingLotRepository.Value;
    public async Task SaveAsync() => await _dbContext.SaveChangesAsync();
}
