using System;

namespace Domain.Entities.Exceptions;

public sealed class RefreshTokenBadRequest : BadRequestException
{
    public RefreshTokenBadRequest()
    : base("Invalid token")
    {
    }
}