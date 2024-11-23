using MosEisleyCantina.Data.Repositories.Entities;

namespace MosEisleyCantina.Service.Services.Contract
{
    public interface IMenuService
    {
        Task<IEnumerable<MenuItem>> GetMenuItems();
        Task<MenuItem> GetMenuItem(int id);
        Task CreateMenuItem(MenuItem menuItem);
        Task UpdateMenuItem(MenuItem menuItem);
        Task DeleteMenuItem(int id);
    }
}
