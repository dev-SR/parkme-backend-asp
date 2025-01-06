using System;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.Exceptions;
public class IdentityException(string message, IEnumerable<IdentityError> errors) : Exception(message)
{
    public IEnumerable<IdentityError> Errors { get; } = errors;
}
