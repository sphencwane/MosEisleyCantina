using MosEisleyCantina.Service.Services.ServiceModels.Requests;
using MosEisleyCantina.Service.Services.ServiceModels.Responses;

namespace MosEisleyCantina.Service.Services.Contract
{
    public interface ICategoryService
    {
        Task<CategoriesResponse> GetCategories();
        Task CreateCategory(CategoryRequest categoryRequest);
    }
}
