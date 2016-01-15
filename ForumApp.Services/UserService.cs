﻿using ForumApp.DataModel;
using ForumApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ForumApp.Services
{
    /// <summary>
    /// IUserService concrete class
    /// </summary>
    public class UserService : IBaseService, IUserService
    {
        private ForumAppEntities _context;

        public UserService(ForumAppEntities context)
        {
            _context = new ForumAppEntities();
        }

        public long CreateUser(UserEntity user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(long userToDelete, long userAttemptinToDelete)
        {
            throw new NotImplementedException();
        }

        public bool DisableUser(long userToDisable, long userAttemptingToDisable)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserEntity> GetAllUsers()
        {
            IEnumerable<User> users = _context.Users.AsEnumerable<User>();
            IEnumerable<UserEntity> userEntities = AutoMapper.Mapper.Map<IEnumerable<UserEntity>>(users);
            return userEntities;
        }

        public UserEntity GetUserByID(long userID)
        {
            User user = null;
            if (userID != 0)
            {
                user = _context.Users.Where(u => u.ID == userID).FirstOrDefault<User>();
            }

            UserEntity userEnitity = AutoMapper.Mapper.Map<UserEntity>(user);
            return userEnitity;
        }

        public UserEntity GetUserByUsername(string username)
        {
            User user = null;
            if (username != null)
            {
                user = _context.Users.Where(u => u.Username == "derick").FirstOrDefault<User>();
            }

            UserEntity userEnitity = AutoMapper.Mapper.Map<UserEntity>(user);
            return userEnitity;
        }

        public ProfileEntity GetUserProfileByUserID(long userID)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(UserEntity user, long userID)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UserService() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        #endregion IDisposable Support
    }
}