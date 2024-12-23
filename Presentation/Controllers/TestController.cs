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

    [HttpGet(Name = "logger")]
    public IActionResult Get()
    {
        _logger.LogInfo("Here is info message from our values controller.");
        _logger.LogDebug("Here is debug message from our values controller.");
        _logger.LogWarn("Here is warn message from our values controller.");
        _logger.LogError("Here is an error message from our values controller.");

        return Ok();
    }
}

