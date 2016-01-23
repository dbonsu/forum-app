namespace ForumApp.Models.IndexVM
{
    public class ForumVM
    {
        public string Description { get; set; }
        public long ID { get; set; }

        public PostVM LatestPost { get; set; }
        public int ThreadNumber { get; set; }
        public string Title { get; set; }
    }
}