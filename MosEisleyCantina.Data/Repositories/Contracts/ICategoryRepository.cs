using MosEisleyCantina.Data.Repositories.Entities;

namespace MosEisleyCantina.Data.Repositories.Contracts
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategories();
        Task CreateCategory(Category category);
    }
}
