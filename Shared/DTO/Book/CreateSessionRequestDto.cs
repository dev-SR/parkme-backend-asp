namespace Shared.DTO.Book;

public record CreateSessionRequestDto(
    Guid parkingSpotId,
    DateTime startTime,
    DateTime endTime,
    string phoneNumber,
    string vehicleNumber
);