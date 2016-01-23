using ForumApp.Common.Utility;
using ForumApp.Services.Interfaces;
using System.Collections.Generic;
using System.Web.Http;

namespace ForumApp.Controllers
{
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

        [Route("api/Debug/Users")]
        [HttpGet]
        public bool A()
        {
            var users = _userService.GetAllUsers();
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

        [Route("api/Debug/createhash")]
        [HttpPost]
        public string GetHash(string password)
        {
            return _passwordHash.CreateHash(password);
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

        [Route("api/Debug/generateToken")]
        [HttpGet]
        public string GetToken(string username, string role)
        {
            var token = _tokenUtility.GenerateToken(username, role);
            _tokenUtility.ValidateToken(token);
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