namespace MosEisleyCantina.Data.Repositories.Entities
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public double Price { get; set; } 
        public string Image { get; set; } 
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Rating> Ratings { get; set; }
    } 
}
