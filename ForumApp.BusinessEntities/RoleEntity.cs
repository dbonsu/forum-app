using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.BusinessEntities
{
    public class RoleEntity
    {
        public long ID { get; set; }
        public string RoleName { get; set; }

        public ICollection<UserEntity> Users { get; set; }
    }
}