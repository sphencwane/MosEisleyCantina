namespace MosEisleyCantina.Service.Services.Models.ReferenceData
{
    public class MenuItemModel
    {
        public int Id { get; set; } = default(int);
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; } = default(double);
        public string Image { get; set; } = string.Empty;
    }
}
