using ForumApp.Common.StaticConfig;
using ForumApp.Common.Utility;
using ForumApp.Models.ObjectVM;
using ForumApp.Services.Interfaces;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Http;

namespace ForumApp.Controllers
{
    public class AccountController : ApiController
    {
        private ILoginService _loginService;
        private ITokenUtility _tokenUtility;
        private IUserService _userService;

        public AccountController(ILoginService loginService, ITokenUtility tokenUtility,
            IUserService userService)
        {
            _loginService = loginService;
            _tokenUtility = tokenUtility;
            _userService = userService;
        }

        [HttpPost]
        [Route("api/Account/Login")]
        public HttpResponseMessage Login([FromBody]LoginVM model)
        {
            if (!ModelState.IsValid || model == null)
            {
                return Request.CreateErrorResponse(System.Net.HttpStatusCode.BadRequest, AccountErrors.INVALID_USER);
            }
            else if (!_loginService.ValidateUser(model.UserName, model.Password))
            {
                return Request.CreateErrorResponse(System.Net.HttpStatusCode.BadRequest, AccountErrors.INVALID_USER);
            }
            else
            {
                var simpleUser = _userService.GetSimpleUser(model.UserName);

                // generate token
                var token = _tokenUtility.GenerateToken(simpleUser.Username, simpleUser.RoleName);
                var response = Request.CreateResponse(HttpStatusCode.OK, "Authorized");
                response.Headers.Add("forum-token", token);
                response.Headers.Add("Access-Control-Expose-Headers", "forum-token");

                //add user principal
                string[] roles = { simpleUser.RoleName };
                var identity = new GenericIdentity(simpleUser.Username, "Basic");
                var principal = new GenericPrincipal(identity, roles);
                Thread.CurrentPrincipal = principal;
                return response;
            }
        }

        private bool A(LoginVM loginVM)
        {
            var username = "derick";
            return loginVM.UserName == username;
        }
    }
}