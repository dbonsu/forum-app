using ForumApp.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Services.Interfaces
{
    /// <summary>
    /// Interface for handling thread replies/posts
    /// </summary>
    public interface IThreadReplyService
    {
        /// <summary>
        /// Creates a new reply
        /// </summary>
        /// <param name="threadReply"></param>
        /// <returns></returns>
        int CreateThreadReply(ThreadReplyEntity threadReply);

        /// <summary>
        /// Deletes a reply that has not been posted
        /// </summary>
        /// <param name="threadReplyID"></param>
        /// <returns></returns>
        bool DeleteThreadReply(long threadReplyID);

        /// <summary>
        /// Retrieved all replies for a thread
        /// </summary>
        /// <param name="threadID"></param>
        /// <returns></returns>
        IEnumerable<ThreadReplyEntity> GetAllThreadRepliesByThreadID(long threadID);

        /// <summary>
        /// Retrieves all replies for a user
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        IEnumerable<ThreadReplyEntity> GetAllThreadRepliesByUserID(long userID);

        /// <summary>
        /// updates a reply
        /// </summary>
        /// <param name="threadReply"></param>
        /// <param name="threadReplyID"></param>
        /// <returns></returns>
        bool UpdateThreadReply(ThreadReplyEntity threadReply, long threadReplyID);
    }
}