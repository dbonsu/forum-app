using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace ForumApp.Filter
{
    public class ForumAuthenticationHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
                    CancellationToken cancellationToken)
        {
            //check if no values in header
            IEnumerable<string> authHeader;
            request.Headers.TryGetValues("Authorization", out authHeader);

            if (authHeader == null)
            {
                var response = new HttpResponseMessage(HttpStatusCode.Forbidden);
                response.Headers.Add("null", "thisisnull");
                var tsc = new TaskCompletionSource<HttpResponseMessage>();
                tsc.SetResult(response);
                return tsc.Task;
            }
            else
            {
                //we have a token
                var bearerToken = authHeader.ElementAt(0);
                var theToken = bearerToken.StartsWith("Bearer ") ? bearerToken.Substring(7) : bearerToken;

                //validate the token and return a simpleUser
                Thread.CurrentPrincipal = ValidaToken(theToken);

                // request.CreateResponse(HttpStatusCode.OK);
                //request.Headers.Add("custom-header", "heyderick");
                var r = request.CreateResponse(HttpStatusCode.OK); // = new System.Net.Http.Headers.AuthenticationHeaderValue("basic");
                                                                   //res.Headers.Add("customheader", "derick");
                var t = new TaskCompletionSource<HttpResponseMessage>();
                t.SetResult(r);
                //return base.SendAsync(request, cancellationToken);
                return t.Task;
            }
        }

        private ClaimsPrincipal ValidaToken(string theToken)
        {
            //to do
            var identity = new GenericIdentity("derick", "Basic");
            var principal = new GenericPrincipal(identity, new string[] { "admin" });
            return principal;
            //throw new NotImplementedException();
        }
    }
}