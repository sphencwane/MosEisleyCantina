using MosEisleyCantina.Data.Repositories.Contracts;
using MosEisleyCantina.Data.Repositories.Entities;
using MosEisleyCantina.Service.Services.Contract;

namespace MosEisleyCantina.Service.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public async Task<IEnumerable<MenuItem>> GetMenuItems()
        {
            return await _menuRepository.GetMenuItems();
        }

        public async Task<MenuItem> GetMenuItem(int id)
        {
            return await _menuRepository.GetMenuItem(id);
        }

        public async Task CreateMenuItem(MenuItem menuItem)
        {
            await _menuRepository.CreateMenuItem(menuItem);
        }

        public async Task UpdateMenuItem(MenuItem menuItem)
        {
            await _menuRepository.UpdateMenuItem(menuItem);
        }

        public async Task DeleteMenuItem(int id)
        {
            await _menuRepository.DeteleMenuItem(id);
        }
    }
}
