using System.Collections.Generic;

namespace ForumApp.Services.Interfaces
{
    /// <summary>
    /// Interface for handling
    /// </summary>
    public interface ITopicService
    {
        /// <summary>
        /// Creates a new topic
        /// </summary>
        /// <param name="topic"></param>
        /// <returns></returns>
        long CreateNewTopic(TopicEntity topic);

        /// <summary>
        /// Deletes a topic
        /// </summary>
        /// <param name="topicEntityID"></param>
        /// <returns></returns>
        bool DeleteTopicEntity(long topicEntityID);

        /// <summary>
        /// Retrieves all threads for topic
        /// </summary>
        /// <param name="topicID"></param>
        /// <returns></returns>
        IEnumerable<ForumThread> GetAllThreadByTopicID(long topicID);

        /// <summary>
        /// Retrieves all topics
        /// </summary>
        /// <returns></returns>
        IEnumerable<TopicEntity> GetAllTopics();

        /// <summary>
        ///
        /// </summary>
        /// <param name="topicID"></param>
        /// <returns></returns>
        TopicEntity GetTopicByID(long topicID);

        /// <summary>
        ///
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        IEnumerable<TopicEntity> GetTopicByUserID(long userID);

        /// <summary>
        /// Updates a topic
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="topicID"></param>
        /// <returns></returns>
        bool UpdateTopicEntity(TopicEntity topic, long topicID);
    }
}