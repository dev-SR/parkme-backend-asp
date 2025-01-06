using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Shared.DTO.Parking;

namespace Presentation.Controllers;

[Route("api/parking-lot/{parkingLotId}/parking-spaces")]
[ApiController]
public class ParkingSpaceController : ControllerBase
{

    private readonly IServiceManager _service;
    public ParkingSpaceController(IServiceManager service) => _service = service;



    [HttpPost]
    public async Task<ActionResult<IEnumerable<ParkingSpaceDto>>> GetParkingSpacesForParkingLot(
                                                                Guid parkingLotId,
                                                                [FromBody] ParkingSpacesFilterReqBodyDto filter)
    {


        var spaces = await _service.ParkingSpaceService.GetParkingSpacesForParkingLot(parkingLotId, filter);
        return Ok(spaces);
    }
}
