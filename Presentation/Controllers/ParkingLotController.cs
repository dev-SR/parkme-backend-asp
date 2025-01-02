using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Shared.DTO.Parking;

namespace Presentation.Controllers;

[Route("api/parking-lot")]
[ApiController]
public class ParkingLotController : ControllerBase
{

    private readonly IServiceManager _service;
    public ParkingLotController(IServiceManager service) => _service = service;


    [HttpPost("search")]
    public async Task<ActionResult<IEnumerable<ParkingLotDto>>> SearchParkingLots([FromBody] ParkingLotSearchFormDto searchFormData)
    {
        var parkingLots = await _service.ParkingLotService.GetParkingLotsWithinBoundingBox(searchFormData);
        return Ok(parkingLots);
    }
}




