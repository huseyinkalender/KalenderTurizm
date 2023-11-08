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
    public class CitiesController : ControllerBase
    {
        private readonly ICityService _cityService;
        public CitiesController(ICityService cityService) => _cityService = cityService;

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            CityDto cityDto = await _cityService.GetCityAsync(id);
            return cityDto is not null ? Ok(cityDto) : BadRequest("Şehir bulunamadı.");
        }


        [HttpGet]
        
        public async Task<IActionResult> GetList()
        {
            List<CityDto> cityDtos = await  _cityService.GetAllCityAsync();
            return Ok(cityDtos);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CityDto cityDto)
        {
            bool response = await _cityService.AddCityAsync(cityDto);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(CityDto cityDto)
        {
            bool response = await _cityService.UpdateCityAsync(cityDto);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(CityDto cityDto)
        {
            bool response = await _cityService.DeleteCityAsync(cityDto);
            return Ok(response);
        }

    }
}
