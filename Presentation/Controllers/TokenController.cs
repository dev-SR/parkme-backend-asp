using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Shared.DTO;

namespace Presentation.Controllers
{
    [Route("api/token")]
    [ApiController]
    public class TokenController : ControllerBase
    {

        private readonly IServiceManager _service;
        public TokenController(IServiceManager service) => _service = service;


        // [HttpPost("refresh")]
        // public async Task<IActionResult> Refresh([FromBody] TokenDto tokenDto)
        // {
        //     var tokenDtoToReturn = await _service.AuthenticationService.RefreshToken(tokenDto);
        //     return Ok(tokenDtoToReturn);
        // }
    }
}
