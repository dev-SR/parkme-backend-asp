using System;

namespace Domain.Entities.Exceptions.BadRequests;

public class PaymentBadRequest : BadRequestException
{
    public PaymentBadRequest(string message) : base(message)
    {
    }
}
