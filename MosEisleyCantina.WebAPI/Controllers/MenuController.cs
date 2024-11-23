using Microsoft.AspNetCore.Mvc;
using MosEisleyCantina.Data.Repositories.Entities;
using MosEisleyCantina.Service.Services.Contract;

namespace MosEisleyCantina.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet("GetMenuItems")]
        public async Task<IActionResult> GetMenuItemsAsync()
        {
            var menuItems = await _menuService.GetMenuItems();
            return Ok(menuItems);
        }

        [HttpGet("GetMenuItem")]
        public async Task<IActionResult> GetMenuItemAsync(int id)
        {
            var menuItem = await _menuService.GetMenuItem(id);
            return Ok(menuItem);
        }

        [HttpPost("CreateMenuItem")]
        public async Task<IActionResult> CreateMenuItemAsync(MenuItem menuItem)
        {
            await _menuService.CreateMenuItem(menuItem);
            return Ok();
        }

        [HttpPut("UpdateMenuItem")]
        public async Task<IActionResult> UpdateMenuItemAsync(MenuItem menuItem)
        {
            await _menuService.UpdateMenuItem(menuItem);
            return Ok();
        }

        [HttpDelete("DeleteMenuItem")]
        public async Task<IActionResult> DeleteMenuItemAsync(int id)
        {
            await _menuService.DeleteMenuItem(id);
            return Ok();
        }
    }
}
