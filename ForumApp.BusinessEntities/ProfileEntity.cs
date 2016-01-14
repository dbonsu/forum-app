namespace ForumApp.BusinessEntities
{
    public class ProfileEntity
    {
        public string AvatarFileName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public long ID { get; set; }
        public string Interests { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public int PostCount { get; set; }
        public UserEntity User { get; set; }
    }
}