using ForumApp.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Services.Interfaces
{
    /// <summary>
    /// Interface for handling IM
    /// </summary>
    public interface IIMServices
    {
        /// <summary>
        /// Creates a new IM
        /// </summary>
        /// <param name="im"></param>
        /// <returns></returns>
        long CreateInstantMessage(InstantMessageEntity im);

        /// <summary>
        /// Removes an IM if not sent
        /// </summary>
        /// <param name="imID"></param>
        /// <returns></returns>
        bool DeleteInstantMessage(long imID);

        /// <summary>
        ///Gets all IM for a user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<InstantMessageEntity> GetAllInstantMessagesByUserID(long id);

        /// <summary>
        /// Gets IM by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        InstantMessageEntity GetInstanMessageByID(long id);

        /// <summary>
        /// Gets IM by user id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        InstantMessageEntity GetInstanMessageByUserID(long id);

        /// <summary>
        /// Gets newer IM based on user id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<InstantMessageEntity> GetRecentInstantMessagesByUserID(long id);

        /// <summary>
        /// Updates IM that has not been sent
        /// </summary>
        /// <param name="im"></param>
        /// <param name="imID"></param>
        /// <returns></returns>
        bool UpdateInstantMessage(InstantMessageEntity im, long imID);

        /// <summary>
        /// Creates a new IMReply
        /// </summary>
        /// <param name="imReply"></param>
        /// <returns></returns>
    }
}