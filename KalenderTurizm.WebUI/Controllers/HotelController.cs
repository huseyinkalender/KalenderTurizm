using KalenderTurizm.Business.Abstract;
using KalenderTurizm.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace KalenderTurizm.WebUI.Controllers
{
    public class HotelController : Controller
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService) => _hotelService = hotelService;
        public IActionResult List()
        {
            return View();
        }

       

        public async Task<IActionResult> GetList()
        {
            List<HotelDto> hotelDtos = await _hotelService.GetAllHotelAsync();
            return View(hotelDtos);

        }

        [HttpGet]
        public async Task<IActionResult> Add() => View();

        [HttpPost]

        public async Task<IActionResult> Add(HotelDto hotelDto)
        {
            bool isTrue = await _hotelService.AddHotelAsync(hotelDto);
            return isTrue ? RedirectToAction("Add") : View();
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
           HotelDto hotelDto = await _hotelService.GetHotelAsync(id);
            return View(hotelDto);
        }

        [HttpPost]

        public async Task<IActionResult> Update(HotelDto hotelDto)
        {
            bool isTrue = await _hotelService.UpdateHotelAsync(hotelDto);
            return isTrue ? RedirectToAction("Index") : View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            bool response = await _hotelService.DeleteHotelAsync((await _hotelService.GetHotelAsync(id)));
            return RedirectToAction("Index");
        }
    }
}
