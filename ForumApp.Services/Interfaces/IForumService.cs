using ForumApp.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        long CreateNewForum(ForumEntity newForum);

        /// <summary>
        /// Removes existing forum entity
        /// </summary>
        /// <param name="ForumEntityID"></param>
        /// <returns></returns>
        bool DeleteForumEntity(long ForumEntityID);

        /// <summary>
        /// Retrieves all forum entities
        /// </summary>
        /// <returns></returns>
        IEnumerable<ForumEntity> GetAllForumEntities();

        /// <summary>
        /// Retrieves all topics for a forum
        /// </summary>
        /// <param name="topicID"></param>
        /// <returns></returns>
        IEnumerable<TopicEntity> GetAllTopicsByForumId(long forumID);

        /// <summary>
        /// Returns a ForumEntity
        /// </summary>
        /// <param name="forumID"></param>
        /// <returns></returns>
        ForumEntity GetForumByID(long forumID);

        /// <summary>
        /// Retrieve forum for user
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        IEnumerable<ForumEntity> GetForumEntityByUserID(long userID);

        /// <summary>
        /// Updates an existing forum
        /// </summary>
        /// <param name="ForumEntityID"></param>
        /// <param name="forumToUpdate"></param>
        /// <returns></returns>
        bool UpdateForumEntity(long ForumEntityID, ForumEntity forumToUpdate);
    }
}