using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Shared;
using Shared.DTO;
using Shared.DTO.Auth;

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
    public async Task<IActionResult> RegisterUser([FromBody] RegistrationRequestDto userForRegistration)
    {
        var result = await _service.AuthenticationService.Register(userForRegistration);
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
    public async Task<ActionResult<LoginResponseDto>> Authenticate([FromBody] LoginRequestDto user)
    {
        var res = await _service.AuthenticationService.Login(user);
        return Ok(res);
    }
}