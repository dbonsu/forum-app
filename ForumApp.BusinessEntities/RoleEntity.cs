using System.Collections.Generic;

namespace ForumApp.BusinessEntities
{
    public class RoleEntity
    {
        public long ID { get; set; }
        public string RoleName { get; set; }

        public ICollection<UserEntity> Users { get; set; }
    }
}