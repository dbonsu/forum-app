using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.BusinessEntities
{
    public class TopicEntity
    {
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public virtual ForumEntity Forum { get; set; }
        public long ForumID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ForumThreadEntity> ForumThreads { get; set; }

        public long ID { get; set; }
        public bool IsClosed { get; set; }
        public int IsSticky { get; set; }
        public int RepliesCount { get; set; }
        public string Subject { get; set; }
        public int ViewsCount { get; set; }
        public bool Visible { get; set; }
    }
}