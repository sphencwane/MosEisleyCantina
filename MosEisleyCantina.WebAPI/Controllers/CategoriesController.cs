using Microsoft.AspNetCore.Mvc;
using MosEisleyCantina.Service.Services.Contract;
using MosEisleyCantina.Service.Services.ServiceModels.Requests;

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
            var categories = await _categoryService.GetCategories();
            return Ok(categories);
        }
          
        [HttpPost("CreateCategory")]
        public async Task<IActionResult> CreateCategoryAsync([FromBody] CategoryRequest categoryRequest)
        {
            await _categoryService.CreateCategory(categoryRequest);
            return Ok();
        }
    }
}
