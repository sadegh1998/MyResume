namespace MvcResume.Models
{
    public class Blog
    {
        public long ID {get; set;}
        public string Title {get; set;}
        public string Description { get; set; }     
        public string Image { get; set; }
        public string Author { get; set; }
        public string Tag { get; set; }
    }
}