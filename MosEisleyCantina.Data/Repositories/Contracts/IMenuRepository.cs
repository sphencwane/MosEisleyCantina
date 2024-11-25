using MosEisleyCantina.Data.Repositories.Entities;

namespace MosEisleyCantina.Data.Repositories.Contracts
{
    public interface IMenuRepository
    {
        Task<List<MenuItem>> GetMenuItems();
        Task<MenuItem> GetMenuItem(int id);
        Task CreateMenuItem(MenuItem menuItem);
        Task UpdateMenuItem(MenuItem menuItem);
        Task DeteleMenuItem(int id);
        Task<List<MenuItem>> SearchMenuItems(string name);
        Task RateMenuItem(Rating rating);
    }
}
