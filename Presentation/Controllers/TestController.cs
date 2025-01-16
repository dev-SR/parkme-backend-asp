using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Shared.DTO.Test;

namespace Presentation.Controllers;
[Route("api/Test")]
[ApiController]
public class TestController(ILoggerManager logger, IServiceManager service) : ControllerBase
{
    private readonly ILoggerManager _logger = logger;
    private readonly IServiceManager _service = service;

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

    [HttpGet("test-db")]
    public async Task<ActionResult<IEnumerable<TesDbRecord>>> TestDbGetAll()
    {
        var res = await _service.TestDbService.GetAllTestDBsAsync();
        return Ok(res);
    }

    [HttpPost("test-db")]
    public async Task<IActionResult> TestDbCreate([FromBody] TestDBCreate testDb)
    {
        await _service.TestDbService.CreateTestDB(testDb);
        return Ok();
    }


}

