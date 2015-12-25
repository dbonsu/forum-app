using ForumApp.BusinessEntities;
using ForumApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IEnumerable<ForumThreadEntity> GetAllThreadByTopicID(long topicID)
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

        public bool UpdateTopicEntity(TopicEntity topic, long topicID)
        {
            throw new NotImplementedException();
        }
    }
}