using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ForumApp.Controllers
{
    public class DebugController : ApiController
    {
        [Route("Debug/id")]
        [HttpGet]
        public int Debug(int i)
        {
            return i;
        }

        [HttpGet]
        public IEnumerable<string> GetTheStrings()
        {
            return new List<string>
            {
                "hell",
                "you",
                "there"
            };
        }

        [HttpGet]
        public IDictionary<string, int> Hello(int an)
        {
            string a = "test";
            return new Dictionary<string, int>()
            {
                {a,an }
            };
        }
    }
}