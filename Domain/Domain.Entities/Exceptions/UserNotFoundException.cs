using System;
using Entities.Exceptions;

namespace Domain.Entities.Exceptions;

public class UserNotFoundException : NotFoundException
{
    public UserNotFoundException(string id) : base($"User({id}) not found") { }
}