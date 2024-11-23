namespace MosEisleyCantina.Data.Repositories.Entities
{
    public class Rating
    {
        public int Id { get; set; }
        public int RatingValue { get; set; } 
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CustomerName { get; set; }
        public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}
