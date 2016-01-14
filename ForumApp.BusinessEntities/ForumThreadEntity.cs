using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.BusinessEntities
{
    public class ForumThreadEntity
    {
        public string Body { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ID { get; set; }
        public Nullable<bool> IsPosted { get; set; }

        public ICollection<ThreadReplyEntity> ThreadReplies { get; set; }

        public virtual TopicEntity Topic { get; set; }

        public virtual UserEntity User { get; set; }

        public Nullable<bool> Visible { get; set; }
    }
}