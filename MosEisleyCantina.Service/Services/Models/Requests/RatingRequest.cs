namespace MosEisleyCantina.Service.Services.Models.Requests
{
    public class RatingRequest
    {
        public int RatingValue { get; set; } = default(int);
        public string Comment { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = default(DateTime);
        public string CustomerName { get; set; } = string.Empty;
        public int MenuItemId { get; set; } = default(int);
    }
}
