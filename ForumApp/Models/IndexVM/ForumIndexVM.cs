using System.Collections.Generic;

namespace ForumApp.Models.IndexVM
{
    public class ForumIndexVM
    {
        public string Description { get; set; }
        public long ID { get; set; }

        public string Title { get; set; }

        public ICollection<TopicVM> Topics { get; set; }
    }
}