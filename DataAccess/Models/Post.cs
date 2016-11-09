namespace DataAccess.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string ImageUri { get; set; }   
        public Category Category { get; set; }
        public string Content { get; set; }
    }
}