using MosEisleyCantina.Data.Repositories.Contracts;
using MosEisleyCantina.Service.Services.Contract;
using MosEisleyCantina.Service.Services.Mappers;
using MosEisleyCantina.Service.Services.Models.ReferenceData;
using MosEisleyCantina.Service.Services.Models.Requests;
using MosEisleyCantina.Service.Services.Models.Responses;

namespace MosEisleyCantina.Service.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public async Task<MenuItemsResponse> GetMenuItems()
        {
            var menuItems = await _menuRepository.GetMenuItems();
            return menuItems.MapToMenuItemsResponse();
        }

        public async Task<MenuItemModel> GetMenuItem(int id)
        {
            var menuItem = await _menuRepository.GetMenuItem(id);
            return menuItem.MapToMenuItemResponse();
        }

        public async Task CreateMenuItem(MenuItemRequest menuItemRequest)
        {
            var menuItem = menuItemRequest.MapToMenuItemRequest();
            await _menuRepository.CreateMenuItem(menuItem);
        }

        public async Task UpdateMenuItem(MenuItemRequest menuItemRequest)
        {
            var menuItem = menuItemRequest.MapToMenuItemUpdateRequest();
            await _menuRepository.UpdateMenuItem(menuItem);
        }

        public async Task DeleteMenuItem(int id)
        {
            await _menuRepository.DeteleMenuItem(id);
        }

        public async Task<MenuItemsResponse> SearchMenuItems(string name)
        {
            var menuItems = await _menuRepository.SearchMenuItems(name);
            return menuItems.MapToMenuItemsResponse();
        }

        public async Task RateMenuItem(RatingRequest ratingRequest)
        {
            var rating = ratingRequest.MapToRatingRequest();
            await _menuRepository.RateMenuItem(rating);
        }
    }
}
