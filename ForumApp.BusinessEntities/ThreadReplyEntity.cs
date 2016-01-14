using System;

namespace ForumApp.BusinessEntities
{
    public class ThreadReplyEntity
    {
        public string Body { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public ForumThreadEntity ForumThread { get; set; }

        public long ID { get; set; }
        public Nullable<bool> IsPosted { get; set; }
        public UserEntity ReplyUser { get; set; }
    }
}