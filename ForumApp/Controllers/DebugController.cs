using ForumApp.BusinessEntities;
using ForumApp.Common.Utility;
using ForumApp.Filter;
using ForumApp.Models.ObjectVM;
using ForumApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace ForumApp.Controllers
{
    public class Body
    {
        public string Name { get; set; }
    }

    public class DebugController : ApiController
    {
        private ILoginService _loginService;
        private IPasswordHash _passwordHash;
        private ITokenUtility _tokenUtility;
        private IUserService _userService;

        public DebugController(IPasswordHash passwordHash, ILoginService loginService,
            IUserService userService, ITokenUtility tokenUtility)
        {
            _passwordHash = passwordHash;
            _loginService = loginService;
            _userService = userService;
            _tokenUtility = tokenUtility;
        }

        [BaseAuthenticationFilter]
        [Route("api/Debug/Users")]
        [HttpGet]
        public bool A()
        {
            var users = _userService.GetUser<SimpleUserDTO>("derick");
            return true;
        }

        [Route("api/Debug/angularuser")]
        [HttpPost]
        public bool AngularTest([FromBody] LoginVM loginVM)
        {
            var result = loginVM;
            return true;
        }

        [Route("api/Debug/TestHash")]
        [HttpPost]
        public bool Debug(string username, string password)
        {
            var r = Request.Headers;
            var login = _loginService.ValidateUser(username, password);
            return login;
        }

        [Route("api/Debug/body")]
        [HttpGet]
        public HttpResponseMessage GetBody(string name)
        {
            var b = new Body { Name = name };
            HttpResponseMessage res;
            if (b.Name.Equals("derick"))
            {
                res = Request.CreateResponse<Body>(HttpStatusCode.OK, b);
            }
            else {
                res = Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            return res;
        }

        [Route("api/Debug/createhash")]
        [HttpPost]
        public string GetHash(string password)
        {
            return _passwordHash.CreateHash(password);
        }

        [BaseAuthenticationFilter]
        [HttpGet]
        [Route("api/Debug/res")]
        public string GetTheStrings()
        {
            return "hello";
        }

        [Route("api/Debug/generateToken")]
        [HttpGet]
        public string GetToken(string username, string role)
        {
            var token = _tokenUtility.GenerateToken(username, role);

            bool a = _tokenUtility.ValidateToken(token);
            return token;
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