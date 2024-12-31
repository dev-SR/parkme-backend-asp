using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Shared.DTO.Auth;

namespace Presentation.Controllers
{
    [Route("api/token")]
    [ApiController]
    public class TokenController : ControllerBase
    {

        private readonly IServiceManager _service;
        public TokenController(IServiceManager service) => _service = service;


        [HttpPost("refresh-token")]
        public async Task<IActionResult> Refresh([FromBody] RefreshTokenRequestDto token)
        {
            var tokenDtoToReturn = await _service.TokenService.ReGenerateAccessToken(token);
            return Ok(tokenDtoToReturn);
        }
    }
}
