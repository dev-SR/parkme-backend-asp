using Shared.DTO.Parking;

namespace Shared.DTO.Book;

// Define the DTOs
public record BookingDto(
    DateTime StartDate,
    DateTime EndDate,
    string Passcode,
    double TotalPrice,
    string VehicleType,
    string SectionName,
    int SpotNumber,
    string Address
);
