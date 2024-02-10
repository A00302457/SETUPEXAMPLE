namespace BlogAPi.Models;
using System.ComponentModel.DataAnnotations;

    public class Post
    {
        public int BlogId { get; set; }
        public DateTime PublishDate { get; set; }
        public int Id { get; set; }
        public string? Name { get; set; }
        
    }
