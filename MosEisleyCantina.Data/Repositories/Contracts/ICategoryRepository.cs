using MosEisleyCantina.Data.Repositories.Entities;

namespace MosEisleyCantina.Data.Repositories.Contracts
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetCategories();
        Task CreateCategory(Category category);
    }
}
