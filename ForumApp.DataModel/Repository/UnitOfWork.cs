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
        private GenericRepository<Topic> _topicRepository;
        private GenericRepository<User> _userRepository;
        private GenericRepository<UserSubscription> _userSubscription;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public UnitOfWork(ForumAppEntities context)
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
                return this._forumRepository;
            }
            set
            {
                this._forumRepository = new GenericRepository<Forum>(_context);
            }
        }

        /// <summary>
        ///Getter/Setter
        /// </summary>
        public GenericRepository<ForumThread> ForumThreadRepository
        {
            get
            {
                return _forumThreadRepository;
            }
            set
            {
                this._forumThreadRepository = new GenericRepository<ForumThread>(_context);
            }
        }

        /// <summary>
        /// Getter/Setter
        /// </summary>
        public GenericRepository<InstantMessage> InstantMessageRepository
        {
            get
            {
                return this._instantMessageRepository;
            }

            set
            {
                this._instantMessageRepository = new GenericRepository<InstantMessage>(_context);
            }
        }

        /// <summary>
        /// Getter/Setter
        /// </summary>
        public GenericRepository<LoginAttempt> LoginAttemptRepository
        {
            get
            {
                return this._loginAttemptRepository;
            }

            set
            {
                this._loginAttemptRepository = new GenericRepository<LoginAttempt>(_context);
            }
        }

        /// <summary>
        /// Getter/Setter
        /// </summary>
        public GenericRepository<Password> PasswordRepository
        {
            get
            {
                return this._passwordRepository;
            }

            set
            {
                this._passwordRepository = new GenericRepository<Password>(_context);
            }
        }

        /// <summary>
        /// Getter/Setter
        /// </summary>
        public GenericRepository<Profile> ProfileRepository
        {
            get
            {
                return this._profileRepository;
            }

            set
            {
                this._profileRepository = new GenericRepository<Profile>(_context);
            }
        }

        /// <summary>
        /// Getter/Setter
        /// </summary>
        public GenericRepository<Role> RoleRepository
        {
            get
            {
                return this._roleRepository;
            }

            set
            {
                this._roleRepository = new GenericRepository<Role>(_context);
            }
        }

        /// <summary>
        /// Getter/Setter
        /// </summary>
        public GenericRepository<ThreadReply> ThreadReplyRepository
        {
            get
            {
                return this._threadReplyRepository;
            }

            set
            {
                this._threadReplyRepository = new GenericRepository<ThreadReply>(_context);
            }
        }

        /// <summary>
        /// Getter/Setter
        /// </summary>
        public GenericRepository<Topic> TopicRepository
        {
            get
            {
                return this._topicRepository;
            }

            set
            {
                this._topicRepository = new GenericRepository<Topic>(_context);
            }
        }

        /// <summary>
        /// Getter/Setter
        /// </summary>
        public GenericRepository<User> UserRepository
        {
            get
            {
                return this._userRepository;
            }

            set
            {
                this._userRepository = new GenericRepository<User>(_context);
            }
        }

        public GenericRepository<UserSubscription> UserSubscription
        {
            get
            {
                return this._userSubscription;
            }

            set
            {
                this._userSubscription = new GenericRepository<UserSubscription>(_context);
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