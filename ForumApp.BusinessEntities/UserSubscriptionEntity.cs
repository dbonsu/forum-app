namespace ForumApp.BusinessEntities
{
    public class UserSubscriptionEntity
    {
        public long ID { get; set; }
        public long SubscriptionID { get; set; }
        public string SubscriptionType { get; set; }
        public virtual UserEntity User { get; set; }
        public long UserID { get; set; }
    }
}