using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.BusinessEntities
{
    public class IMReplyEntity
    {
        public string Body { get; set; }
        public System.DateTime CreationDate { get; set; }
        public long FromUser { get; set; }
        public long ID { get; set; }
        public virtual InstantMessageEntity InstantMessage { get; set; }
        public long InstantMessageID { get; set; }
        public bool IsNew { get; set; }
        public long ToUser { get; set; }
    }
}