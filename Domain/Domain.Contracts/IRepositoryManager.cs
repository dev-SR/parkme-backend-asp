namespace Domain.Contracts;
public interface IRepositoryManager
{
    IRefreshTokenRepository RefreshToken { get; }
    IParkingLotRepository ParkingLot { get; }
    IParkingSpaceRepository ParkingSpace { get; }

    IBookingRepository Booking { get; }
    Task SaveAsync();
}