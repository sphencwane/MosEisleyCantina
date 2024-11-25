using MosEisleyCantina.Data.Repositories.Contracts;
using MosEisleyCantina.Service.Services.Contract;
using MosEisleyCantina.Service.Services.Mappers;
using MosEisleyCantina.Service.Services.ServiceModels.Requests;
using MosEisleyCantina.Service.Services.ServiceModels.Responses;

namespace MosEisleyCantina.Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<CategoriesResponse> GetCategories()
        {
            var categories = await _categoryRepository.GetCategories();
            return categories.MapToCategoryResponse();
        }

        public async Task CreateCategory(CategoryRequest categoryRequest)
        {
            var categoryRequestModel = categoryRequest.MapToCategoryRequest();
            await _categoryRepository.CreateCategory(categoryRequestModel);
        }
    }
}
