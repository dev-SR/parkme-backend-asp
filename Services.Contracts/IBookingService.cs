using System;
using Shared.DTO;
using Shared.DTO.Book;

namespace Services.Contracts;

public interface IBookingService
{
    Task<CreateSessionResponseDto> CreateSession(Guid userId, CreateSessionRequestDto createSessionRequestDto);
    Task<BookingDto> ConfirmBooking(string sessionId);
}
