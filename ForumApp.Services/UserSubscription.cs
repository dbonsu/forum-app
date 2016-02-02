using ForumApp.BusinessEntities;
using ForumApp.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ForumApp.Services
{
    /// <summary>
    /// IUserSubscription concrete class
    /// </summary>
    public class UserSubscription : IUserSubscriptionService
    {
        public long CreateSubscription(UserSubscriptionEntity sub)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSubscription(long subID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserSubscriptionEntity> GetAllForumSubscriptions(long userID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserSubscriptionEntity> GetAllThreadSubscriptions(long userID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserSubscriptionEntity> GetAllTopicSubscriptions(long userID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserSubscriptionEntity> GetAllUserSubscriptions(long userID)
        {
            throw new NotImplementedException();
        }

        public UserSubscriptionEntity GetSubscriptionByID(long subID)
        {
            throw new NotImplementedException();
        }

        public UserSubscriptionEntity GetSubscriptionByUserID(long userID)
        {
            throw new NotImplementedException();
        }
    }
}