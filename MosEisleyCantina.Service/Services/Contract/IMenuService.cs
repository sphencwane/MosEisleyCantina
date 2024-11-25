using MosEisleyCantina.Service.Services.Models.ReferenceData;
using MosEisleyCantina.Service.Services.Models.Requests;
using MosEisleyCantina.Service.Services.Models.Responses;

namespace MosEisleyCantina.Service.Services.Contract
{
    public interface IMenuService
    {
        Task<MenuItemsResponse> GetMenuItems();
        Task<MenuItemModel> GetMenuItem(int id);
        Task CreateMenuItem(MenuItemRequest menuItemRequest);
        Task UpdateMenuItem(MenuItemRequest menuItemRequest);
        Task DeleteMenuItem(int id);
        Task<MenuItemsResponse> SearchMenuItems(string name);
        Task RateMenuItem(RatingRequest ratingRequest);
    }
}
