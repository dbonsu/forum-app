using ForumApp.BusinessEntities;
using System.Collections.Generic;

namespace ForumApp.Services.Interfaces
{
    public interface IForumThreadService
    {
        long CreateForumThread(ForumThreadEntity thread);

        bool DeleteThread(long threadID);

        /// <summary>
        /// Retrieved all replies for a thread
        /// </summary>
        /// <param name="threadID"></param>
        /// <returns></returns>
        IEnumerable<ThreadReplyEntity> GetAllRepliesByThreadID(long threadID);

        /// <summary>
        /// Retrieves all threads for a user
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        IEnumerable<ForumThreadEntity> GetAllThreadByUserID(long userID);

        /// <summary>
        /// Gets a thread
        /// </summary>
        /// <param name="thread"></param>
        /// <returns></returns>
        ForumThreadEntity GetForumThreadByID(long thread);

        /// <summary>
        /// updates a thread
        /// </summary>
        /// <param name="thread"></param>
        /// <param name="threadID"></param>
        /// <returns></returns>
        bool UpdateForumReply(ForumThreadEntity thread, long threadID);
    }
}