using NLog;
using Services.Contracts;

public class AuthorizationHeaderMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILoggerManager _logger;

    public AuthorizationHeaderMiddleware(RequestDelegate next, ILoggerManager logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        _logger.LogInfo($"Request path: {context.Request.Path}");

        if (context.Request.Headers.TryGetValue("Authorization", out var authorizationHeader))
        {
            _logger.LogInfo($"Authorization header found: {authorizationHeader}");
            // You can further process the authorization header here, 
            // such as validating the token or extracting user information.
        }
        else
        {
            _logger.LogInfo("Authorization header not found in the request.");
        }

        await _next(context);
    }
}