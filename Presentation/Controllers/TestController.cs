using Microsoft.AspNetCore.Authorization;
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
        return Ok(new
        {
            Success = true,
        });
    }
}

