using System;
using Domain.Entities.Models;
using Shared.DTO.Book;

namespace Domain.Contracts;

public interface IBookingRepository
{
    void CreateSession(Guid userId, ParkingSpace parkingSpace, CreateSessionRequestDto createSessionRequestDto, string? stripeSessionId);
    Task<Booking?> FindBySessionId(string sessionId, bool trackChanges);

}
