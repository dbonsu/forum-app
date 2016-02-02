namespace ForumApp.Models.IndexVM
{
    public class PostVM
    {
        public string Body { get; set; }
        public string JoinDate { get; set; }
        public string PostDate { get; set; }
        public long PostID { get; set; }
        public string Subject { get; set; }
        public long TopicID { get; set; }
        public UserProfileVM User { get; set; }
    }
}