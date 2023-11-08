using KalenderTurizm.Business.Abstract;
using KalenderTurizm.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace KalenderTurizm.WebUI.Controllers
{
    public class PlaceToVisitController : Controller
    {
        private readonly IPlaceToVisitService _placeToVisitService;

        public PlaceToVisitController(IPlaceToVisitService placeToVisitService) => _placeToVisitService = placeToVisitService;
        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> GetList()
        {
            List<PlaceToVisitDto> placeToVisitDtos = await _placeToVisitService.GetAllPlaceToVisitAsync();
            return View(placeToVisitDtos);

        }

        [HttpGet]
        public async Task<IActionResult> Add() => View("Add");

        [HttpPost]

        public async Task<IActionResult> Add(PlaceToVisitDto placeToVisitDto)
        {
            if (ModelState.IsValid)
            {
                // Model geçerli, burada kaydetme işlemini gerçekleştirin.
                _placeToVisitService.AddPlaceToVisitAsync(placeToVisitDto);

                // Başarı durumunda başka bir sayfaya yönlendirme veya işlem sonuç mesajı ekleyebilirsiniz.
                return RedirectToAction("GetList");
            }

            // Model geçerli değil, hata mesajlarını otomatik olarak görünüme ekler
            return View(placeToVisitDto);



            //    bool isTrue = await _placeToVisitService.AddPlaceToVisitAsync(placeToVisitDto);
            //    return isTrue ? RedirectToAction("GetList") : View();
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            PlaceToVisitDto placeToVisitDto = await _placeToVisitService.GetPlaceToVisitAsync(id);
            return View(placeToVisitDto);
        }

        [HttpPost]

        public async Task<IActionResult> Update(PlaceToVisitDto placeToVisitDto)
        {
            bool isTrue = await _placeToVisitService.UpdatePlaceToVisitAsync(placeToVisitDto);
            return isTrue ? RedirectToAction("GetList") : View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            bool response = await _placeToVisitService.DeletePlaceToVisitAsync((await _placeToVisitService.GetPlaceToVisitAsync(id)));
            return RedirectToAction("GetList");
        }
    }
}
