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
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThreadReplyEntity> ThreadReplies { get; set; }

        public virtual TopicEntity Topic { get; set; }
        public long TopicID { get; set; }
        public virtual UserEntity User { get; set; }
        public bool Visible { get; set; }
    }
}