namespace DataAccesLayer.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string ImageURL { get; set; }   
        public Category Category { get; set; }
        public string Content { get; set; }
    }
}