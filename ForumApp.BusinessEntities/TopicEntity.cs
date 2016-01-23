using System.Collections.Generic;

namespace ForumApp.BusinessEntities
{
    public class TopicEntity
    {
        public System.DateTime CreatedOn { get; set; }
        public ForumEntity Forum { get; set; }

        public ICollection<ForumThreadEntity> ForumThreads { get; set; }

        public long ID { get; set; }
        public bool IsClosed { get; set; }
        public int IsSticky { get; set; }
        public int RepliesCount { get; set; }
        public string Subject { get; set; }
        public UserEntity User { get; set; }
        public int ViewsCount { get; set; }
        public bool Visible { get; set; }
    }
}