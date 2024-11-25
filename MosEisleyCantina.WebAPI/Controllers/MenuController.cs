using Microsoft.AspNetCore.Mvc;
using MosEisleyCantina.Service.Services.Contract;
using MosEisleyCantina.Service.Services.Models.Requests;

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

        [HttpGet("SearchMenuItem")]
        public async Task<IActionResult> SearchMenuItemAsync(string name)
        {
            var menuItem = await _menuService.SearchMenuItems(name);
            return Ok(menuItem);
        }

        [HttpPost("CreateMenuItem")]
        public async Task<IActionResult> CreateMenuItemAsync(MenuItemRequest menuItemRequest)
        {
            await _menuService.CreateMenuItem(menuItemRequest);
            return Ok();
        }

        [HttpPut("UpdateMenuItem")]
        public async Task<IActionResult> UpdateMenuItemAsync(MenuItemRequest menuItemRequest)
        {
            await _menuService.UpdateMenuItem(menuItemRequest);
            return Ok();
        }

        [HttpDelete("DeleteMenuItem")]
        public async Task<IActionResult> DeleteMenuItemAsync(int id)
        {
            await _menuService.DeleteMenuItem(id);
            return Ok();
        }

        [HttpPost("RateMenuItem")]
        public async Task<IActionResult> RateMenuItemAsync(RatingRequest ratingRequest)
        {
            await _menuService.RateMenuItem(ratingRequest);
            return Ok();
        }
    }
}
