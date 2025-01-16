
using Domain.Contracts;

namespace Infrastructure.Data.Repositories;

public class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryDbContext _dbContext;
    private readonly Lazy<IRefreshTokenRepository> _refreshTokenRepository;
    private readonly Lazy<IParkingLotRepository> _parkingLotRepository;
    public readonly Lazy<IParkingSpaceRepository> _parkingSpaceRepository;
    public readonly Lazy<IBookingRepository> _bookingRepository;
    private readonly Lazy<ITestDbRepository> _testDbRepository;

    public RepositoryManager(RepositoryDbContext dbContext)
    {
        _dbContext = dbContext;
        _refreshTokenRepository = new Lazy<IRefreshTokenRepository>(() => new RefreshTokenRepository(dbContext));
        _parkingLotRepository = new Lazy<IParkingLotRepository>(() => new ParkingLotRepository(dbContext));
        _parkingSpaceRepository = new Lazy<IParkingSpaceRepository>(() => new ParkingSpaceRepository(dbContext));
        _bookingRepository = new Lazy<IBookingRepository>(() => new BookingRepository(dbContext, this));//this->repositoryManager it self

        _testDbRepository = new Lazy<ITestDbRepository>(() => new TestDbRepository(dbContext));

    }
    public IRefreshTokenRepository RefreshToken => _refreshTokenRepository.Value;
    public IParkingLotRepository ParkingLot => _parkingLotRepository.Value;
    public IParkingSpaceRepository ParkingSpace => _parkingSpaceRepository.Value;
    public IBookingRepository Booking => _bookingRepository.Value;

    public ITestDbRepository TestDb => _testDbRepository.Value;


    public async Task SaveAsync() => await _dbContext.SaveChangesAsync();
}
