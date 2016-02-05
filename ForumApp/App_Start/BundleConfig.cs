using System.Web.Optimization;

namespace ForumApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/vendor/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/vendor/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/vendor/bootstrap.js",
                      "~/Scripts/vendor/respond.js"));
            bundles.Add(new ScriptBundle("~/bundle/forum").Include(
                    "~/Scripts/forum/Login.js",
                     "~/Scripts/forum/Logout.js"
                    ));

            bundles.Add(new ScriptBundle("~/bundles/angularVendor").Include(
                "~/Scripts/vendor/angular.min.js",
                "~/Scripts/vendor/angular-ui-router.min.js",
                "~/Scripts/vendor/angular-resource.min.js"

                ));

            bundles.Add(new ScriptBundle("~/bundles/angularForum").Include(
                    "~/Angular/app.js",
                    "~/Angular/forum/forumController.js",
                    "~/Angular/login/loginController.js"

                ));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/vendor/bootstrap.css",
                      "~/Content/forum/Site.css",
                      "~/Content/forum/Forum.css",
                      "~/Content/forum/Login.css"));
        }
    }
}