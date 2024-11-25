using MosEisleyCantina.Data.Repositories.Entities;
using MosEisleyCantina.Service.Services.Models.ReferenceData;
using MosEisleyCantina.Service.Services.ServiceModels.Requests;
using MosEisleyCantina.Service.Services.ServiceModels.Responses;

namespace MosEisleyCantina.Service.Services.Mappers
{
    public static class CategoryMappers
    {
        public static CategoriesResponse MapToCategoryResponse(this List<Category> categories)
        {
            CategoriesResponse categoryResponse = new CategoriesResponse();

            foreach (var category in categories)
            {
                categoryResponse.categories.Add(new CategoryModel() { Id = category.Id, Name = category.Name });
            }

            return categoryResponse;
        }

        public static Category MapToCategoryRequest(this CategoryRequest categoryRequest)
        {
            Category category = new Category();
            category.Name = categoryRequest.Name;

            return category;
        }
    }
}
