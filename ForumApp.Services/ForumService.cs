using ForumApp.BusinessEntities;
using ForumApp.DataModel;
using ForumApp.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ForumApp.Services
{
    /// <summary>
    /// IForumService concrete class
    /// </summary>
    public class ForumService : BaseService, IForumService
    {
        private ForumAppEntities forumAppEntities;

        public ForumService(ForumAppEntities forumAppEntities)
        {
            _context = forumAppEntities;
        }

        public long CreateNewForum(Forum newForum)
        {
            throw new NotImplementedException();
        }

        public bool DeleteForum(long ForumID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Forum> GetAllForumEntities()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TopicEntity> GetAllTopicsByForumId(long forumID)
        {
            throw new NotImplementedException();
        }

        public Forum GetForumByID(long forumID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Forum> GetForumByUserID(long userID)
        {
            throw new NotImplementedException();
        }

        public bool UpdateForum(long ForumID, Forum forumToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}