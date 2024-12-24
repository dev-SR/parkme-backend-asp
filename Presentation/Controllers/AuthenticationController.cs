using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
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


    [HttpGet("current-user")]
    [Authorize]
    public async Task<ActionResult<UserResponseDto>> CurrentUser()
    {
        //More https://stackoverflow.com/questions/38751616/asp-net-core-identity-get-current-user
        ClaimsPrincipal currentUser = this.User;
        var userId = currentUser.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        // bool isAdmin = currentUser.IsInRole("Admin");
        // bool isUser = currentUser.IsInRole("User");
        // var email = currentUser.FindFirst(ClaimTypes.Email)?.Value;
        // var roles = currentUser.FindAll(ClaimTypes.Role).Select(c => c.Value);
        // return Ok(new
        // {
        //     userId,
        //     email,
        //     isAdmin,
        //     isUser,
        //     roles
        // });
        if (userId != null)
        {
            return BadRequest("User not found");
        }

        var user = await _service.AuthenticationService.GetCurrentUser(userId!);
        return Ok(user);
    }
}