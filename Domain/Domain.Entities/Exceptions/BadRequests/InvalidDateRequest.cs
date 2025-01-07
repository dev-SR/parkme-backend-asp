using System;

namespace Domain.Entities.Exceptions.BadRequests;

public class InvalidDateRequest : BadRequestException
{
    public InvalidDateRequest(string message) : base(message)
    {
    }
}
