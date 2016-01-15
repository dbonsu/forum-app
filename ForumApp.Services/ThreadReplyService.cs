using ForumApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Services
{
    /// <summary>
    /// IThreadReplyService concrete class
    /// </summary>
    public class ThreadReplyService : IThreadReplyService
    {
        public long CreateThreadReply(ThreadReplyEntity threadReply)
        {
            throw new NotImplementedException();
        }

        public bool DeleteThreadReply(long threadReplyID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ThreadReplyEntity> GetAllThreadRepliesByUserID(long userID)
        {
            throw new NotImplementedException();
        }

        public ThreadReplyEntity GetThreadReplyByID(long threadReplyID)
        {
            throw new NotImplementedException();
        }

        public bool UpdateThreadReply(ThreadReplyEntity threadReply, long threadReplyID)
        {
            throw new NotImplementedException();
        }
    }
}