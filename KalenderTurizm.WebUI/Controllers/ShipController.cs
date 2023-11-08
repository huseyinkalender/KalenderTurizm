using KalenderTurizm.Business.Abstract;
using KalenderTurizm.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace KalenderTurizm.WebUI.Controllers
{
    public class ShipController : Controller
    {
        private readonly IShipService _shipService;

        public ShipController(IShipService shipService) => _shipService = shipService;
        public IActionResult List()
        {
            return View();
        }

       

        public async Task<IActionResult> GetList()
        {
            List<ShipDto> shipDtos = await _shipService.GetAllShipAsync(); ;
            return View(shipDtos);

        }

        [HttpGet]
        public async Task<IActionResult> Add() => View();

        [HttpPost]

        public async Task<IActionResult> Add(ShipDto shipDto)
        {
            bool isTrue = await _shipService.AddShipAsync(shipDto);
            return isTrue ? RedirectToAction("Add") : View();
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            ShipDto shipDto = await _shipService.GetShipAsync(id);
            return View(shipDto);
        }

        [HttpPost]

        public async Task<IActionResult> Update(ShipDto shipDto)
        {
            bool isTrue = await _shipService.UpdateShipAsync(shipDto);
            return isTrue ? RedirectToAction("GetList") : View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            bool response = await _shipService.DeleteShipAsync((await _shipService.GetShipAsync(id)));
            return RedirectToAction("GetList");
        }
    }
}
