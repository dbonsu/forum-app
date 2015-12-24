using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.BusinessEntities
{
    public class PasswordEntity
    {
        public System.DateTime CreateDate { get; set; }
        public string Hash { get; set; }
        public long ID { get; set; }
        public bool IsActive { get; set; }
        public string Salt { get; set; }
        public virtual UserEntity User { get; set; }
        public long UserID { get; set; }
    }
}