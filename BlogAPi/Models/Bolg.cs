namespace BlogAPi.Models;
using System.ComponentModel.DataAnnotations;

    public class Blog
    {
        public int BlogId { get; set; }
        public DateTime PublishDate { get; set; }
        [Url]
        public string? Name { get; set; }
        [Url]
        public Uri? Uri { get; set; }
        
    }
