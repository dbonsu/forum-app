using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.BusinessEntities
{
    public class LoginAttemptEntity
    {
        public long ID { get; set; }
        public System.DateTime LoginDate { get; set; }
        public virtual UserEntity User { get; set; }
        public Nullable<long> UserID { get; set; }
    }
}