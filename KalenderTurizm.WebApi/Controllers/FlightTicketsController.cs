using KalenderTurizm.Business.Abstract;
using KalenderTurizm.Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KalenderTurizm.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightTicketsController : ControllerBase
    {
        private readonly IFlightTicketService _flightTicketService;
        public FlightTicketsController(IFlightTicketService flightTicketService) => _flightTicketService = flightTicketService;

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            FlightTicketDto flightTicketDto = await _flightTicketService.GetFlightTicketAsync(id);
            return flightTicketDto is not null ? Ok(flightTicketDto) : BadRequest("Uçak bileti bulunamadı.");
        }


        [HttpGet]

        public async Task<IActionResult> GetList()
        {
            List<FlightTicketDto> flightTicketDtos = await _flightTicketService.GetAllFlightTicketAsync();
            return Ok(flightTicketDtos);
        }

        [HttpPost]
        public async Task<IActionResult> Add(FlightTicketDto flightTicketDto)
        {
            bool response = await _flightTicketService.AddFlightTicketAsync(flightTicketDto);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(FlightTicketDto flightTicketDto)
        {
            bool response = await _flightTicketService.UpdateFlightTicketAsync(flightTicketDto);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(FlightTicketDto flightTicketDto)
        {
            bool response = await _flightTicketService.DeleteFlightTicketAsync(flightTicketDto);
            return Ok(response);
        }
    }
}
