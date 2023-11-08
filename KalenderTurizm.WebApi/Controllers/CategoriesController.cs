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
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> Gets()
        {
            List<CategoryDto> categoryDtos = await _categoryService.GetCategoriesAllAsync();
            return Ok(categoryDtos);
        }
        [HttpPost]
        public async Task<IActionResult> Add(CategoryDto categoryDto)
        {
            var response = await _categoryService.AddCategoryAsync(categoryDto);
            return response ? Ok(response) : BadRequest();
        }
        [HttpPut]
        public async Task<IActionResult> Update(CategoryDto categoryDto)
        {
            bool response = await _categoryService.UpdateCategoryAsync(categoryDto);
            if (response)
            {
                return Ok(response);
            }
            return BadRequest();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(CategoryDto categoryDto)
        {
            bool response = await _categoryService.DeleteCategoryAsync(categoryDto);
            return response ? Ok("Silme işlemi başarılı!") : BadRequest(categoryDto);
        }

    }

}

