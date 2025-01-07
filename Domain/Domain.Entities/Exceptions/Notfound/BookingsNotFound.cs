using System;
using Entities.Exceptions;

namespace Domain.Entities.Exceptions.Notfound;

public class BookingsNotFound : NotFoundException
{
    public BookingsNotFound(string message) : base(message)
    {
    }
}
