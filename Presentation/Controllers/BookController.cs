using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Shared.DTO;
using Shared.DTO.Book;

namespace Presentation.Controllers;

[Route("api/book")]
[ApiController]
public class BookController : ControllerBase
{

    private readonly IServiceManager _service;
    public BookController(IServiceManager service) => _service = service;



    [HttpPost("create-checkout-session")]
    [Authorize]
    public async Task<ActionResult<CreateSessionResponseDto>> CreateCheckoutSession([FromBody] CreateSessionRequestDto data)
    {
        ClaimsPrincipal currentUser = this.User;
        var userIdString = currentUser.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        Guid userId;
        if (!Guid.TryParse(userIdString, out userId))
        {
            return BadRequest("Invalid user ID");
        }
        await _service.AuthenticationService._ValidateUser(userId!);

        var res = await _service.BookingService.CreateSession(userId, data);
        return Ok(res);

    }

    [HttpGet("confirmed-booking/{sessionId}")]
    public async Task<ActionResult<BookingDto>> ConfirmBooking(string sessionId)
    {
        var res = await _service.BookingService.ConfirmBooking(sessionId);
        return Ok(res);
    }
}
