namespace Domain.Contracts;
public interface IRepositoryManager
{
    IRefreshTokenRepository RefreshToken { get; }
    IParkingLotRepository ParkingLot { get; }
    Task SaveAsync();
}