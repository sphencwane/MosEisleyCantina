using MosEisleyCantina.Service.Services.Models.ReferenceData;

namespace MosEisleyCantina.Service.Services.Models.Responses
{
    public class MenuItemsResponse
    {
        public List<MenuItemModel> menuItems { get; set; } = new List<MenuItemModel>();
    }
}
