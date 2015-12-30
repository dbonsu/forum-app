using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.BusinessEntities
{
    public class ForumEntity
    {
        public string Description { get; set; }

        public long ID { get; set; }

        public string Title { get; set; }

        public ICollection<TopicEntity> Topics { get; set; }

        public virtual UserEntity User { get; set; }
    }
}