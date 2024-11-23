using MosEisleyCantina.Data.Repositories.Entities;

namespace MosEisleyCantina.Data.Repositories.Contracts
{
    public interface IMenuRepository
    {
        Task<IEnumerable<MenuItem>> GetMenuItems();
        Task<MenuItem> GetMenuItem(int id);
        Task CreateMenuItem(MenuItem menuItem);
        Task UpdateMenuItem(MenuItem menuItem);
        Task DeteleMenuItem(int id);
    }
}
