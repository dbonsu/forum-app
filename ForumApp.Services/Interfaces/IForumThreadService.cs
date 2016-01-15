using ForumApp.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Services.Interfaces
{
    public interface IForumThreadService
    {
        long CreateForumThread(ForumThread thread);

        bool DeleteThread(long threadID);

        /// <summary>
        /// Retrieved all replies for a thread
        /// </summary>
        /// <param name="threadID"></param>
        /// <returns></returns>
        IEnumerable<ThreadReply> GetAllRepliesByThreadID(long threadID);

        /// <summary>
        /// Retrieves all threads for a user
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        IEnumerable<ForumThread> GetAllThreadByUserID(long userID);

        /// <summary>
        /// Gets a thread
        /// </summary>
        /// <param name="thread"></param>
        /// <returns></returns>
        ForumThread GetForumThreadByID(long thread);

        /// <summary>
        /// updates a thread
        /// </summary>
        /// <param name="thread"></param>
        /// <param name="threadID"></param>
        /// <returns></returns>
        bool UpdateForumReply(ForumThread thread, long threadID);
    }
}