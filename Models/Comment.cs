namespace TestingMVC.Models
{
    public class Comment
    {
        public int Id { get; set; } 
        public string Body { get; set; }

        public Models.Post Post { get; set; }
    }
}
