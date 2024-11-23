using MosEisleyCantina.Data.Repositories;
using MosEisleyCantina.Data.Repositories.Contracts;
using MosEisleyCantina.Data.Repositories.Entities;
using MosEisleyCantina.Service.Services.Contract;

namespace MosEisleyCantina.Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _categoryRepository.GetCategories();
        }

        public async Task CreateCategory(Category Category)
        {
            await _categoryRepository.CreateCategory(Category);
        }
    }
}
