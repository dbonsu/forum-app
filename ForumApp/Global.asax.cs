using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ForumApp
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static void AutoMapperConfiguration()
        {
            WebAutoMapping.WebMapperConfig.Configure();
            Services.ServiceAutoMapping.ServiceMapperConfig.Configure();
            DataModel.DataModelAutoMapping.DataModelMapperConfig.Configure();
            Common.CommonAutoMapping.CommonMapperConfig.Configure();
            BusinessEntities.BusinessAutoMapping.BusinessMapperConfig.Configure();
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfiguration();
        }
    }
}