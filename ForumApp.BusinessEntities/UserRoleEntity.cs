using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.BusinessEntities
{
    public class UserRoleEntity
    {
        public long ID { get; set; }
        public virtual RoleEntity Role { get; set; }
        public long RoleID { get; set; }
        public virtual UserEntity User { get; set; }
        public long UserID { get; set; }
    }
}