using System.Collections.Generic;

namespace ForumApp.Models.IndexVM
{
    public class ThreadVM
    {
        public string Body { get; set; }
        public PostVM LatestPost { get; set; }
        public int NumOfPosts { get; set; }
        public string PostDate { get; set; }
        public long ThreadID { get; set; }
        public ICollection<PostVM> ThreadReplies { get; set; }
        public string Title { get; set; }
        public long TopicID { get; set; }
        public UserProfileVM User { get; set; }
    }
}