using ForumApp.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Services.Interfaces
{
    /// <summary>
    /// Interface for handling user subscriptions
    /// </summary>
    public interface IUserSubscriptionService

    {
        /// <summary>
        /// Create a new subscription
        /// </summary>
        /// <param name="sub"></param>
        /// <returns></returns>
        long CreateSubscription(UserSubscriptionEntity sub);

        /// <summary>
        /// Deletes an existing subscription
        /// </summary>
        /// <param name="subID"></param>
        /// <returns></returns>
        bool DeleteSubscription(long subID);

        /// <summary>
        /// Retrieves all forum level subscriptions
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        IEnumerable<UserSubscriptionEntity> GetAllForumSubscriptions(long userID);

        /// <summary>
        /// Retrieves all thread and reply level subscriptions
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        IEnumerable<UserSubscriptionEntity> GetAllThreadSubscriptions(long userID);

        /// <summary>
        ///
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        IEnumerable<UserSubscriptionEntity> GetAllTopicSubscriptions(long userID);

        /// <summary>
        /// Retrieves all user subscriptions
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        IEnumerable<UserSubscriptionEntity> GetAllUserSubscriptions(long userID);

        /// <summary>
        /// Gets subscription by id
        /// </summary>
        /// <param name="subID"></param>
        /// <returns></returns>
        UserSubscriptionEntity GetSubscriptionByID(long subID);

        /// <summary>
        /// Gets subscriptions by user id
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        UserSubscriptionEntity GetSubscriptionByUserID(long userID);
    }
}