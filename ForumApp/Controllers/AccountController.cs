using ForumApp.Models.ObjectVM;
using System.Net.Http;
using System.Web.Http;

namespace ForumApp.Controllers
{
    public class AccountController : ApiController
    {
        [HttpPost]
        [Route("api/Account/Login")]
        public HttpResponseMessage Login([FromBody]LoginVM model)
        {
            if (!ModelState.IsValid || model == null)
            {
                return Request.CreateErrorResponse(System.Net.HttpStatusCode.BadRequest, "User name and or password is incorrect");
            }
            if (model.UserName != null)
            {
                //check username in in db by calling validate or some other method
                //todo
                if (!A(model))
                {
                    return Request.CreateErrorResponse(System.Net.HttpStatusCode.BadRequest, "User name and or password is incorrect");
                }
            }
            //provide token

            return new HttpResponseMessage(System.Net.HttpStatusCode.Accepted);
        }

        private bool A(LoginVM loginVM)
        {
            var username = "derick";
            return loginVM.UserName == username;
        }
    }
}