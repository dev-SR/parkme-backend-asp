using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Presentation.Controllers;
[Route("api/Test")]
[ApiController]
public class TestController : ControllerBase
{
    private readonly ILoggerManager _logger;
    public TestController(ILoggerManager logger)
    {
        _logger = logger;
    }

    [HttpGet("logger")]
    public IActionResult Get()
    {
        _logger.LogInfo($"{nameof(TestController)} Here is info message from our values controller.");
        _logger.LogDebug($"{nameof(TestController)} Here is debug message from our values controller.");
        _logger.LogWarn($"{nameof(TestController)} Here is warn message from our values controller.");
        _logger.LogError($"{nameof(TestController)} Here is an error message from our values controller.");

        return Ok();
    }

    [HttpGet("protected")]
    [Authorize]
    public IActionResult GetProtected()
    {
        return Ok("This is an protected endpoint");
    }

    [HttpGet("current-user")]
    [Authorize]
    public IActionResult CurrentUser()
    {
        // https://stackoverflow.com/questions/38751616/asp-net-core-identity-get-current-user
        ClaimsPrincipal currentUser = this.User;
        bool isAdmin = currentUser.IsInRole("Admin");
        bool isUser = currentUser.IsInRole("User");
        var userId = currentUser.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        var email = currentUser.FindFirst(ClaimTypes.Email)?.Value;

        var roles = currentUser.FindAll(ClaimTypes.Role).Select(c => c.Value);

        return Ok(new
        {
            userId,
            email,
            isAdmin,
            isUser,
            roles
        });
    }
}

