using KalenderTurizm.Business.Abstract;
using KalenderTurizm.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace KalenderTurizm.WebUI.Controllers
{
    public class FlightTicketController : Controller
    {
        private readonly IFlightTicketService _flightTicketService;

        public FlightTicketController(IFlightTicketService flightTicketService) => _flightTicketService = flightTicketService;
        public IActionResult List()
        {
            return View();
        }

      

        public async Task<IActionResult> GetList()
        {
            List<FlightTicketDto> flightTicketDtos = await _flightTicketService.GetAllFlightTicketAsync();
            return View(flightTicketDtos);

        }

        [HttpGet]
        public async Task<IActionResult> Add() => View();

        [HttpPost]

        public async Task<IActionResult> Add(FlightTicketDto flightTicketDto)
        {
            bool isTrue = await _flightTicketService.AddFlightTicketAsync(flightTicketDto);
            return isTrue ? RedirectToAction("Add") : View();
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            FlightTicketDto flightTicketDto = await _flightTicketService.GetFlightTicketAsync(id);
            return View(flightTicketDto);
        }

        [HttpPost]

        public async Task<IActionResult> Update(FlightTicketDto flightTicketDto)
        {
            bool isTrue = await _flightTicketService.UpdateFlightTicketAsync(flightTicketDto);
            return isTrue ? RedirectToAction("GetList") : View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            bool response = await _flightTicketService.DeleteFlightTicketAsync((await _flightTicketService.GetFlightTicketAsync(id)));
            return RedirectToAction("GetList");
        }


    }
}
