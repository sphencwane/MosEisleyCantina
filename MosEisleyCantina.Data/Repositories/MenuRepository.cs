using Microsoft.EntityFrameworkCore;
using MosEisleyCantina.Data.Repositories.Contracts;
using MosEisleyCantina.Data.Repositories.Entities;

namespace MosEisleyCantina.Data.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        private readonly AppDbContext _context;

        public MenuRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MenuItem>> GetMenuItems()
        {
            try
            {
                return await _context.MenuItems.Include(m => m.Category).ToListAsync();
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<MenuItem> GetMenuItem(int id)
        {
            try
            {
                return await _context.MenuItems.Include(m => m.Category).Include(m => m.Ratings).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task CreateMenuItem(MenuItem menuItem)
        {
            try
            {
                var category = await _context.Categories.FindAsync(menuItem.CategoryId);

                if (category == null) 
                {
                    throw new("Category not found.");
                }

                _context.MenuItems.Add(menuItem);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateMenuItem(MenuItem menuItem)
        {
            try
            {
                _context.Entry(menuItem).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeteleMenuItem(int id)
        {
            try
            {
                var menuItem = await _context.MenuItems.FindAsync(id);

                if (menuItem == null)
                {
                    throw new("Menu item not found.");
                }

                _context.MenuItems.Remove(menuItem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<MenuItem>> SearchMenuItems(string name)
        {
            return await _context.MenuItems.Where(m => m.Name.Contains(name)).ToListAsync();
        }
    }
}
