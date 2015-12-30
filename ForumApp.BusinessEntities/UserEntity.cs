using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.BusinessEntities
{
    public class UserEntity
    {
        public UserEntity()
        {
            this.Fora = new HashSet<ForumEntity>();
            this.ForumThreads = new HashSet<ForumThreadEntity>();
            this.InstantMessages = new HashSet<InstantMessageEntity>();
            this.InstantMessages1 = new HashSet<InstantMessageEntity>();
            this.LoginAttempts = new HashSet<LoginAttemptEntity>();
            this.Passwords = new HashSet<PasswordEntity>();
            this.Profiles = new HashSet<ProfileEntity>();
            this.UserRoles = new HashSet<UserRoleEntity>();
            this.UserSubscriptions = new HashSet<UserSubscriptionEntity>();
        }

        public System.DateTime CreateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ForumEntity> Fora { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ForumThreadEntity> ForumThreads { get; set; }

        public long ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstantMessageEntity> InstantMessages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstantMessageEntity> InstantMessages1 { get; set; }

        public bool IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoginAttemptEntity> LoginAttempts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PasswordEntity> Passwords { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfileEntity> Profiles { get; set; }

        public string Username { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRoleEntity> UserRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserSubscriptionEntity> UserSubscriptions { get; set; }
    }
}