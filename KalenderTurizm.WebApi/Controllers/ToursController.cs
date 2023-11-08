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
    public class ToursController : ControllerBase
    {
        private readonly ITourService _tourService;

        public ToursController(ITourService tourService)
        {
            _tourService = tourService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            TourDto tourDto = await _tourService.GetTourAsync(id);
            return Ok(tourDto);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<TourDto> tourDtos = await _tourService.GetAllTourAsync();
            return Ok(tourDtos);
        }
        [HttpPost]
        public async Task<IActionResult> Add(TourDto tourDto)
        {
            bool res = await _tourService.AddTourAsync(tourDto);
            return Ok(res);
        }
        [HttpPut]
        public async Task<IActionResult> Update(TourDto tourDto)
        {
            bool res = await _tourService.UpdateTourAsync(tourDto);
            return Ok(res);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(TourDto tourDto)
        {
            bool response = await _tourService.DeleteTourAsync(tourDto);
            return Ok(response);
        }


    }
}
