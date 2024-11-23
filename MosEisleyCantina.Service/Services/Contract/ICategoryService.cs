using MosEisleyCantina.Data.Repositories.Entities;

namespace MosEisleyCantina.Service.Services.Contract
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategories();
        Task CreateCategory(Category Category);
    }
}
