using Microsoft.AspNetCore.Mvc;
using MosEisleyCantina.Data.Repositories.Entities;
using MosEisleyCantina.Service.Services.Contract;

namespace MosEisleyCantina.WebAPI.Controllers
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

        [HttpGet("GetCategories")]
        public async Task<IActionResult> GetCategoriesAsync()
        {
            await _categoryService.GetCategories();
            return Ok();
        }
          
        [HttpPost("CreateCategory")]
        public async Task<IActionResult> CreateCategoryAsync(Category category)
        {
            await _categoryService.CreateCategory(category);
            return Ok();
        }
    }
}
