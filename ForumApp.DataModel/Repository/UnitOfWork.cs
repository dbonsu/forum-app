using ForumApp.DataModel.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.DataModel.Repository
{
    /// <summary>
    /// Concreate implementation of IUnitOfWork
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private ForumAppEntities _context = null;
        private bool _dispose = false;
        private GenericRepository<Forum> _forumRepository;
        private GenericRepository<ForumThread> _forumThreadRepository;
        private GenericRepository<InstantMessage> _instantMessageRepository;
        private GenericRepository<LoginAttempt> _loginAttemptRepository;
        private GenericRepository<Password> _passwordRepository;
        private GenericRepository<Profile> _profileRepository;
        private GenericRepository<Role> _roleRepository;
        private GenericRepository<ThreadReply> _threadReplyRepository;
        private GenericRepository<Token> _tokenRepository;
        private GenericRepository<Topic> _topicRepository;
        private GenericRepository<User> _userRepository;
        private GenericRepository<UserSubscription> _userSubscription;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public UnitOfWork()
        {
            _context = new ForumAppEntities();
        }

        /// <summary>
        /// Getter/Setter
        /// </summary>
        public GenericRepository<Forum> ForumRepository
        {
            get
            {
                if (this._forumRepository == null)
                {
                    this._forumRepository = new GenericRepository<Forum>(_context);
                }
                return this._forumRepository;
            }
        }

        /// <summary>
        ///Getter/Setter
        /// </summary>
        public GenericRepository<ForumThread> ForumThreadRepository
        {
            get
            {
                if (this._forumThreadRepository == null)
                {
                    this._forumThreadRepository = new GenericRepository<ForumThread>(_context);
                }
                return this._forumThreadRepository;
            }
        }

        /// <summary>
        /// Getter/Setter
        /// </summary>
        public GenericRepository<InstantMessage> InstantMessageRepository
        {
            get
            {
                if (this._instantMessageRepository == null)
                {
                    this._instantMessageRepository = new GenericRepository<InstantMessage>(_context);
                }

                return this._instantMessageRepository;
            }
        }

        /// <summary>
        /// Getter/Setter
        /// </summary>
        public GenericRepository<LoginAttempt> LoginAttemptRepository
        {
            get
            {
                if (this._loginAttemptRepository == null)
                {
                    this._loginAttemptRepository = new GenericRepository<LoginAttempt>(_context);
                }
                return this._loginAttemptRepository;
            }
        }

        /// <summary>
        /// Getter/Setter
        /// </summary>
        public GenericRepository<Password> PasswordRepository
        {
            get
            {
                if (this._passwordRepository == null)
                {
                    this._passwordRepository = new GenericRepository<Password>(_context);
                }
                return this._passwordRepository;
            }

            //set
            //{
            //    this._passwordRepository = new GenericRepository<Password>(_context);
            //}
        }

        /// <summary>
        /// Getter/Setter
        /// </summary>
        public GenericRepository<Profile> ProfileRepository
        {
            get
            {
                if (this._profileRepository == null)
                {
                    this._profileRepository = new GenericRepository<Profile>(_context);
                }
                return this._profileRepository;
            }
        }

        /// <summary>
        /// Getter/Setter
        /// </summary>
        public GenericRepository<Role> RoleRepository
        {
            get
            {
                if (this._roleRepository == null)
                {
                    this._roleRepository = new GenericRepository<Role>(_context);
                }
                return this._roleRepository;
            }
        }

        /// <summary>
        /// Getter/Setter
        /// </summary>
        public GenericRepository<ThreadReply> ThreadReplyRepository
        {
            get
            {
                if (this._threadReplyRepository == null)
                {
                    this._threadReplyRepository = new GenericRepository<ThreadReply>(_context);
                }
                return this._threadReplyRepository;
            }
        }

        public GenericRepository<Token> TokenRepository
        {
            get
            {
                if (this._tokenRepository == null)
                {
                    this._tokenRepository = new GenericRepository<Token>(_context);
                }
                return this._tokenRepository;
            }
        }

        /// <summary>
        /// Getter/Setter
        /// </summary>
        public GenericRepository<Topic> TopicRepository
        {
            get
            {
                if (this._topicRepository == null)
                {
                    this._topicRepository = new GenericRepository<Topic>(_context);
                }
                return this._topicRepository;
            }
        }

        /// <summary>
        /// Getter/Setter
        /// </summary>
        public GenericRepository<User> UserRepository
        {
            get
            {
                if (this._userRepository == null)
                {
                    this._userRepository = new GenericRepository<User>(_context);
                }
                return this._userRepository;
            }
        }

        public GenericRepository<UserSubscription> UserSubscription
        {
            get
            {
                if (this._userSubscription == null)
                {
                    this._userSubscription = new GenericRepository<UserSubscription>(_context);
                }

                return this._userSubscription;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_dispose)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _dispose = true;
            }
        }

        /// <summary>
        /// Method for saving changes to db
        /// </summary>
        public virtual void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                ICollection<string> outputs = new List<string>();
                foreach (var err in ex.EntityValidationErrors)
                {
                    outputs.Add(string.Format(
                        "{0}: Entity of type \"{1}\" in state \"{2}\" has the following validation errors:", DateTime.Now,
                        err.Entry.Entity.GetType().Name, err.Entry.State));
                    foreach (var r in err.ValidationErrors)
                    {
                        outputs.Add(string.Format("- Property: \"{0}\", Error: \"{1}\"", r.PropertyName, r.ErrorMessage));
                    }
                }
                System.IO.File.AppendAllLines(@"C:\saveerrors.txt", outputs);

                throw ex;
            }
        }
    }
}