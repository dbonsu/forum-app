using ForumApp.BusinessEntities;
using ForumApp.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ForumApp.Services
{
    /// <summary>
    /// IForumService concrete class
    /// </summary>
    public class ForumService : IForumService
    {
        public long CreateNewForum(ForumEntity newForum)
        {
            throw new NotImplementedException();
        }

        public bool DeleteForumEntity(long ForumEntityID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ForumEntity> GetAllForumEntities()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TopicEntity> GetAllTopicsByForumId(long forumID)
        {
            throw new NotImplementedException();
        }

        public ForumEntity GetForumByID(long forumID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ForumEntity> GetForumEntityByUserID(long userID)
        {
            throw new NotImplementedException();
        }

        public bool UpdateForumEntity(long ForumEntityID, ForumEntity forumToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}