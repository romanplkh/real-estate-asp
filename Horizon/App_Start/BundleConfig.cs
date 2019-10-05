using System.Web;
using System.Web.Optimization;
using System.Web.UI.WebControls;

namespace Horizon
{
    public class BundleConfig
    {
        // SCRIPT BUNDLES
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
               "~/Scripts/popper.js"));


            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/owl").Include(
               "~/Scripts/owl.carousel.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/slick").Include(
               "~/Scripts/slick.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
               "~/Scripts/app.js"));




         //Style BUNDLES

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/CSS/bundle.css"));
            bundles.Add(new StyleBundle("~/Content/fonts").Include(
               "~/Content/Fonts/webfonts/all.css"));
        }
    }
}
