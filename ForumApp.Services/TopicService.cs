using ForumApp.BusinessEntities;
using ForumApp.DataModel;
using ForumApp.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ForumApp.Services
{
    /// <summary>
    /// ITopicService concrete class
    /// </summary>
    public class TopicService : ITopicService
    {
        public long CreateNewTopic(TopicEntity topic)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTopicEntity(long topicEntityID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ForumThread> GetAllThreadByTopicID(long topicID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TopicEntity> GetAllTopics()
        {
            throw new NotImplementedException();
        }

        public TopicEntity GetTopicByID(long topicID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TopicEntity> GetTopicByUserID(long userID)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ForumThreadEntity> ITopicService.GetAllThreadByTopicID(long topicID)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTopicEntity(TopicEntity topic, long topicID)
        {
            throw new NotImplementedException();
        }
    }
}