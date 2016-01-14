namespace ForumApp.BusinessEntities
{
    public class PasswordEntity
    {
        public System.DateTime CreateDate { get; set; }
        public string Hash { get; set; }
        public long ID { get; set; }
        public bool IsActive { get; set; }

        public virtual UserEntity User { get; set; }
    }
}