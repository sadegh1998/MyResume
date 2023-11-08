namespace MvcResume.Models.Old
{
    public class Experience
    {
        public long ID { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Company { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }

    }

}