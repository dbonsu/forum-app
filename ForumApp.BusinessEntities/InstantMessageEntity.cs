using System;

namespace ForumApp.BusinessEntities
{
    public class InstantMessageEntity
    {
        public string Body { get; set; }
        public System.DateTime CreationDate { get; set; }

        public UserEntity FromUserEntity { get; set; }
        public long ID { get; set; }

        public Nullable<bool> IsNew { get; set; }
        public Nullable<bool> IsSent { get; set; }
        public Nullable<long> ParentID { get; set; }

        public UserEntity ToUserEntity { get; set; }
    }
}