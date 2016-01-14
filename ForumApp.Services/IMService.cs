using ForumApp.BusinessEntities;
using ForumApp.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ForumApp.Services
{
    /// <summary>
    /// Instant Message concrete class
    /// </summary>
    public class IMService : IIMService
    {
        public long CreateInstantMessage(InstantMessageEntity im)
        {
            throw new NotImplementedException();
        }

        public bool DeleteInstantMessage(long imID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InstantMessageEntity> GetAllInstantMessagesByUserID(long id)
        {
            throw new NotImplementedException();
        }

        public InstantMessageEntity GetInstanMessageByID(long id)
        {
            throw new NotImplementedException();
        }

        public InstantMessageEntity GetInstanMessageByUserID(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InstantMessageEntity> GetRecentInstantMessagesByUserID(long id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateInstantMessage(InstantMessageEntity im, long imID)
        {
            throw new NotImplementedException();
        }
    }
}