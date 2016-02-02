using ForumApp.BusinessEntities;
using ForumApp.DataModel;
using System.Collections.Generic;

namespace ForumApp.Services.Interfaces
{
    /// <summary>
    /// Interface for forum table interactions
    /// </summary>
    public interface IForumService
    {
        /// <summary>
        /// Creates a new forum
        /// </summary>
        /// <param name="newForum"></param>
        /// <returns></returns>
        long CreateNewForum(Forum newForum);

        /// <summary>
        /// Removes existing forum entity
        /// </summary>
        /// <param name="ForumID"></param>
        /// <returns></returns>
        bool DeleteForum(long ForumID);

        /// <summary>
        /// Retrieves all forum entities
        /// </summary>
        /// <returns></returns>
        IEnumerable<Forum> GetAllForumEntities();

        /// <summary>
        /// Retrieves all topics for a forum
        /// </summary>
        /// <param name="topicID"></param>
        /// <returns></returns>
        IEnumerable<TopicEntity> GetAllTopicsByForumId(long forumID);

        /// <summary>
        /// Returns a Forum
        /// </summary>
        /// <param name="forumID"></param>
        /// <returns></returns>
        Forum GetForumByID(long forumID);

        /// <summary>
        /// Retrieve forum for user
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        IEnumerable<Forum> GetForumByUserID(long userID);

        /// <summary>
        /// Updates an existing forum
        /// </summary>
        /// <param name="ForumID"></param>
        /// <param name="forumToUpdate"></param>
        /// <returns></returns>
        bool UpdateForum(long ForumID, Forum forumToUpdate);
    }
}