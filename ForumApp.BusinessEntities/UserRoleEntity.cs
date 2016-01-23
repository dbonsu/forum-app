namespace ForumApp.BusinessEntities
{
    public class UserRoleEntity
    {
        public long ID { get; set; }
        public RoleEntity Role { get; set; }

        public UserEntity User { get; set; }
    }
}