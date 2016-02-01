using ForumApp.Filter;
using System.Web.Mvc;

namespace ForumApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new BaseAuthenticationFilter());
        }
    }
}