namespace TestingMVC.Models
{
    public class Post
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Body { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
