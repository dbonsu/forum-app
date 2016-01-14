using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForumApp.Models.IndexVM
{
    public class TopicVM
    {
        public string Description { get; set; }
        public long ForumID { get; set; }
        public PostVM LatestPost { get; set; }
        public int NumOfThreads { get; set; }
        public ICollection<ThreadVM> Threads { get; set; }
        public string Title { get; set; }
        public long TopicID { get; set; }
    }
}