using System;
using Entities.Exceptions;

namespace Domain.Entities.Exceptions;

public class ParkingSpaceNotFoundException : NotFoundException
{
    public ParkingSpaceNotFoundException(Guid id) : base($"ParkingSpace({id}) not found") { }
}