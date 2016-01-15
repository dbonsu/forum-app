using ForumApp.DataModel;
using ForumApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Services
{
    /// <summary>
    /// IForumService concrete class
    /// </summary>
    public class ForumService : IForumService
    {
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