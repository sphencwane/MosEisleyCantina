using MosEisleyCantina.Service.Services.Models.ReferenceData;

namespace MosEisleyCantina.Service.Services.ServiceModels.Responses
{
    public class CategoriesResponse
    {
       public List<CategoryModel> categories { get; set; } = new List<CategoryModel>();
    }
}
