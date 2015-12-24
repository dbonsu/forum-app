using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.DataModel.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        GenericRepository<Forum> ForumRepository { get; set; }
        GenericRepository<ForumThread> ForumThreadRepository { get; set; }
        GenericRepository<InstantMessageReply> InstantMessageReply { get; set; }
        GenericRepository<InstantMessage> InstantMessageRepository { get; set; }
        GenericRepository<LoginAttempt> LoginAttemptRepository { get; set; }
        GenericRepository<Password> PasswordRepository { get; set; }
        GenericRepository<Profile> ProfileRepository { get; set; }
        GenericRepository<Role> RoleRepository { get; set; }
        GenericRepository<ThreadReply> ThreadReplyRepository { get; set; }
        GenericRepository<Topic> TopicRepository { get; set; }
        GenericRepository<User> UserRepository { get; set; }

        /// <summary>
        /// Save method.
        /// </summary>
        void Save();
    }
}