using KalenderTurizm.Business.Abstract;
using KalenderTurizm.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace KalenderTurizm.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService) => _categoryService = categoryService;

        public async Task<IActionResult> GetList()
        {
            List<CategoryDto> categoryDtos = await _categoryService.GetCategoriesAllAsync();
            return View(categoryDtos);

        }

        [HttpGet]
        public async Task<IActionResult> Add() => View();

        [HttpPost]

        public async Task<IActionResult> Add(CategoryDto categoryDto)
        {
            bool isTrue = await _categoryService.AddCategoryAsync(categoryDto);
            return isTrue ? RedirectToAction("GetList") : View();
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            CategoryDto categoryDto = await _categoryService.GetCategoryAsync(id);
            return View(categoryDto);
        }

        [HttpPost]

        public async Task<IActionResult> Update(CategoryDto categoryDto)
        {
            bool isTrue = await _categoryService.UpdateCategoryAsync(categoryDto);
            return isTrue ? RedirectToAction("GetList") : View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            bool response = await _categoryService.DeleteCategoryAsync((await _categoryService.GetCategoryAsync(id)));
            return RedirectToAction("Index");
        }
        
    }
}
