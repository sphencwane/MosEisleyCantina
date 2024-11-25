using MosEisleyCantina.Service.Services.Models.ReferenceData;

namespace MosEisleyCantina.Service.Services.Models.Requests
{
    public class MenuItemRequest : MenuItemModel
    {
        public int CategoryId { get; set; } = default(int);
    }
}
