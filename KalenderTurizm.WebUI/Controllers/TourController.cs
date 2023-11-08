using KalenderTurizm.Business.Abstract;
using KalenderTurizm.Entities.Concrete;
using KalenderTurizm.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace KalenderTurizm.WebUI.Controllers
{
    public class TourController : Controller
    {
        private readonly ITourService _tourService;

        public TourController(ITourService tourService) => _tourService = tourService;
        public IActionResult List()
        {
            return View();
        }

       

        public async Task<IActionResult> GetList()
        {
            List<TourDto> tourDtos = await _tourService.GetAllTourAsync();
            return View(tourDtos);

        }

        [HttpGet]
        public async Task<IActionResult> Add() => View("Add");

        [HttpPost]

        public async Task<IActionResult> Add(TourDto tourDto)
        {
            bool isTrue = await _tourService.AddTourAsync(tourDto);
            return isTrue ? RedirectToAction("GetList") : View();
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            TourDto tourDto = await _tourService.GetTourAsync(id);
            return View(tourDto);
        }

        [HttpPost]

        public async Task<IActionResult> Update(TourDto tourDto)
        {
            bool isTrue = await _tourService.UpdateTourAsync(tourDto);
            return isTrue ? RedirectToAction("GetList") : View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            bool response = await _tourService.DeleteTourAsync((await _tourService.GetTourAsync(id)));
            return RedirectToAction("GetList");
        }

    }
}
