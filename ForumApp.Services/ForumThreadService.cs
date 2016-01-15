using ForumApp.DataModel;
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
        public long CreateForumThread(ForumThread thread)
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

        public IEnumerable<ForumThread> GetAllThreadByUserID(long userID)
        {
            throw new NotImplementedException();
        }

        public ForumThread GetForumThreadByID(long thread)
        {
            throw new NotImplementedException();
        }

        public bool UpdateForumReply(ForumThread thread, long threadID)
        {
            throw new NotImplementedException();
        }
    }
}