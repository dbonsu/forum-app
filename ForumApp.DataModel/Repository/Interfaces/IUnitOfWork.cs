using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.DataModel.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        GenericRepository<Forum> ForumRepository { get; }
        GenericRepository<ForumThread> ForumThreadRepository { get; }

        GenericRepository<InstantMessage> InstantMessageRepository { get; }
        GenericRepository<LoginAttempt> LoginAttemptRepository { get; }
        GenericRepository<Password> PasswordRepository { get; }
        GenericRepository<Profile> ProfileRepository { get; }
        GenericRepository<Role> RoleRepository { get; }
        GenericRepository<ThreadReply> ThreadReplyRepository { get; }
        GenericRepository<Token> TokenRepository { get; }
        GenericRepository<Topic> TopicRepository { get; }
        GenericRepository<User> UserRepository { get; }
        GenericRepository<UserSubscription> UserSubscription { get; }

        /// <summary>
        /// Save method.
        /// </summary>
        void Save();
    }
}