using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Shared;
using Shared.DTO;

namespace Presentation.Controllers;

[Route("api/auth")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly ILoggerManager _logger;
    public AuthenticationController(IServiceManager service, ILoggerManager logger)
    {
        _service = service;
        _logger = logger;
    }


    [HttpPost("register")]
    public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistration)
    {
        var result = await _service.AuthenticationService.RegisterUser(userForRegistration);
        if (!result.Succeeded)
        {
            foreach (var error in result.Errors)
            {

                ModelState.TryAddModelError(error.Code, error.Description);
            }
            return BadRequest(ModelState);
        }
        return StatusCode(201);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Authenticate([FromBody] UserForLoginDto user)
    {
        if (!await _service.AuthenticationService.ValidateUser(user))
            return Unauthorized(
                new { Message = "Wrong email or password." }
            );
        var tokenDto = await _service.AuthenticationService.CreateToken(populateExp: true);
        return Ok(tokenDto);
    }
}