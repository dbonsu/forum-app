using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.BusinessEntities
{
    public class ForumEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ForumEntity()
        {
            this.Topics = new HashSet<TopicEntity>();
        }

        public string Description { get; set; }

        public long ID { get; set; }

        public string Title { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TopicEntity> Topics { get; set; }

        public virtual UserEntity User { get; set; }

        public long UserID { get; set; }
    }
}