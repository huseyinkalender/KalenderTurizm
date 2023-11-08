using KalenderTurizm.Business.Abstract;
using KalenderTurizm.Entities.Concrete;
using KalenderTurizm.Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KalenderTurizm.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceToVisitsController : ControllerBase
    {
        private readonly IPlaceToVisitService _placeToVisitService;

        public PlaceToVisitsController(IPlaceToVisitService placeToVisitService)
        {
            _placeToVisitService = placeToVisitService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
           PlaceToVisitDto placeToVisitDto = await _placeToVisitService.GetPlaceToVisitAsync(id);
            return Ok(placeToVisitDto);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<PlaceToVisitDto> placeToVisitDtos = await _placeToVisitService.GetAllPlaceToVisitAsync();
            return Ok(placeToVisitDtos);
        }
        [HttpPost]
        public async Task<IActionResult> Add(PlaceToVisitDto placeToVisitDto)
        {
            bool res = await _placeToVisitService.AddPlaceToVisitAsync(placeToVisitDto);
            return Ok(res);
        }
        [HttpPut]
        public async Task<IActionResult> Update(PlaceToVisitDto placeToVisitDto)
        {
            bool res = await _placeToVisitService.UpdatePlaceToVisitAsync(placeToVisitDto);
            return Ok(res);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(PlaceToVisitDto placeToVisitDto)
        {
            bool response = await _placeToVisitService.DeletePlaceToVisitAsync(placeToVisitDto);
            return Ok(response);
        }

    }
}
