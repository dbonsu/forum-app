using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.BusinessEntities
{
    public class UserEntity
    {
        public System.DateTime CreateDate { get; set; }

        public ICollection<ForumEntity> Fora { get; set; }

        public ICollection<ForumThreadEntity> ForumThreads { get; set; }

        public long ID { get; set; }

        public ICollection<InstantMessageEntity> InstantMessages { get; set; }

        public bool IsActive { get; set; }

        public ICollection<LoginAttemptEntity> LoginAttempts { get; set; }

        public ICollection<PasswordEntity> Passwords { get; set; }

        public ProfileEntity Profile { get; set; }

        public ICollection<TokenEntity> Tokens { get; set; }
        public string Username { get; set; }

        public ICollection<UserRoleEntity> UserRoles { get; set; }
        public ICollection<UserSubscriptionEntity> UserSubscriptions { get; set; }
    }
}