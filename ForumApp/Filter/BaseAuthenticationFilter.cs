using ForumApp.Common.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace ForumApp.Filter
{
    /// <summary>
    /// Main authentication filter for the forumApp
    /// </summary>
    public class BaseAuthenticationFilter : AuthorizationFilterAttribute
    {
        //http://www.asp.net/web-api/overview/security/authentication-filters
        private ITokenUtility _tokenUtility;

        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="tokenUtility"></param>
        public BaseAuthenticationFilter()
        {
            _tokenUtility = new TokenUtility();
        }

        /// <summary>
        /// Main method for performing validation
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnAuthorization(HttpActionContext filterContext)
        {
            //IEnumerable<string> authHeader;
            //filterContext.Request.Headers.TryGetValues("Authorization", out authHeader);
            string authToken = filterContext.Request.Headers.Authorization.Parameter;

            if (authToken == null)
            {
                ChallengeAuthRequest(filterContext);
                return;
            }

            var principal = ValidateToken(authToken);
            if (principal == null)
            {
                ChallengeAuthRequest(filterContext);
                return;
            }

            Thread.CurrentPrincipal = principal;

            base.OnAuthorization(filterContext);
        }

        ///// <summary>
        ///// Send the Authentication Challenge request
        ///// </summary>
        ///// <param name="filterContext"></param>
        private static void ChallengeAuthRequest(HttpActionContext filterContext)
        {
            var dnsHost = filterContext.Request.RequestUri.DnsSafeHost;
            filterContext.Response = filterContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            filterContext.Response.Headers.Add("WWW-Authenticate", string.Format("Basic realm=\"{0}\"", dnsHost));
        }

        ///// <summary>
        ///// Grabs the token out of the authorization header
        ///// </summary>
        ///// <param name="authHeader"></param>
        ///// <returns></returns>
        private string ValidateAuthHeader(string authHeader)
        {
            //if (authHeader.ToList().Count == 0) return null;
            //var bearerToken = authHeader.ElementAt(0);
            var theToken = authHeader.StartsWith("Bearer ") ? authHeader.Substring(7) : null;

            return theToken;
        }

        /// <summary>
        /// takes a valid token
        /// </summary>
        /// <param name="theToken"></param>
        /// <returns></returns>
        private ClaimsPrincipal ValidateToken(string theToken)
        {
            try
            {
                var claimP = _tokenUtility.ValidateAndReadToken(theToken);
                return claimP;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        #region web api

        //public Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        //{
        //    // 1. Look for credentials in the request.
        //    HttpRequestMessage request = context.Request;
        //    IEnumerable<string> authHeader;
        //    request.Headers.TryGetValues("Authorization", out authHeader);

        //    // 2. If there are no credentials, do nothing.
        //    if (authHeader == null)
        //    {
        //        context.ErrorResult = new AuthenticationFailureResult("You are not authorized", request);
        //        return Task.FromResult(request);
        //    }

        //    // 3. If there are credentials but the filter does not recognize the
        //    //    authentication scheme, do nothing.
        //    var token = ValidateAuthHeader(authHeader);
        //    if (token == null)
        //    {
        //        context.ErrorResult = new AuthenticationFailureResult("You are not authorized", request);
        //        return Task.FromResult(request);
        //    }

        //    var claimsPrincipal = ValidateToken(token);
        //    if (claimsPrincipal == null)
        //    {
        //        context.ErrorResult = new AuthenticationFailureResult("You are not authorized", request);
        //        return Task.FromResult(request);
        //    }

        //    IPrincipal principal = claimsPrincipal;
        //    context.Principal = principal;
        //    return AuthenticateAsync(context, cancellationToken);
        //}

        //public Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        //{
        //    var challenge = new AuthenticationHeaderValue("Basic");
        //    context.Result = new AddChallengeOnUnauthorizedResult(challenge, context.Result);
        //    return Task.FromResult(0);
        //}

        #endregion web api
    }
}