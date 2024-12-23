using System;

namespace Services.Contracts;

public interface IServiceManager
{
    IAuthenticationService AuthenticationService { get; }
}
