using System.Collections.Generic;

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
        long CreateThreadReply(ThreadReplyEntity threadReply);

        /// <summary>
        /// Deletes a reply that has not been posted
        /// </summary>
        /// <param name="threadReplyID"></param>
        /// <returns></returns>
        bool DeleteThreadReply(long threadReplyID);

        /// <summary>
        /// Retrieves all replies for a user
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        IEnumerable<ThreadReplyEntity> GetAllThreadRepliesByUserID(long userID);

        /// <summary>
        /// Gets a reply by id
        /// </summary>
        /// <param name="threadReplyID"></param>
        /// <returns></returns>
        ThreadReplyEntity GetThreadReplyByID(long threadReplyID);

        /// <summary>
        /// updates a reply
        /// </summary>
        /// <param name="threadReply"></param>
        /// <param name="threadReplyID"></param>
        /// <returns></returns>
        bool UpdateThreadReply(ThreadReplyEntity threadReply, long threadReplyID);
    }
}