using MosEisleyCantina.Data.Repositories.Contracts;
using MosEisleyCantina.Data.Repositories.Entities;

namespace MosEisleyCantina.Data.Repositories
{
    public class RatingRepository : IRatingRepository
    {
        private readonly AppDbContext _context;

        public RatingRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task RateMenuItem(Rating rating)
        {
            if(rating.RatingValue < 1 || rating.RatingValue > 5)
            {
                throw new Exception("Rating must be between 1 and 5.");
            }

            var menuItem = await _context.MenuItems.FindAsync(rating.MenuItemId);

            if (menuItem == null)
            {
                throw new Exception("Menu item not found.");
            }

            rating.CreatedAt = DateTime.Now;

            _context.Ratings.Add(rating);
            await _context.SaveChangesAsync();
        }
    }
}
