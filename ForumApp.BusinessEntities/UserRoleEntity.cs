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
        public RoleEntity Role { get; set; }

        public UserEntity User { get; set; }
    }
}