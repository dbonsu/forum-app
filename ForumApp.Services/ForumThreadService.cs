using ForumApp.BusinessEntities;
using ForumApp.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ForumApp.Services
{
    /// <summary>
    /// IForumThreadService concreate class
    /// </summary>
    public class ForumThreadService : IForumThreadService
    {
        public long CreateForumThread(ForumThreadEntity thread)
        {
            throw new NotImplementedException();
        }

        public bool DeleteThread(long threadID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ThreadReplyEntity> GetAllRepliesByThreadID(long threadID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ForumThreadEntity> GetAllThreadByUserID(long userID)
        {
            throw new NotImplementedException();
        }

        public ForumThreadEntity GetForumThreadByID(long thread)
        {
            throw new NotImplementedException();
        }

        public bool UpdateForumReply(ForumThreadEntity thread, long threadID)
        {
            throw new NotImplementedException();
        }
    }
}