using System.Web;
using System.Web.Optimization;

namespace DreamJunction
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/easing/easing.min.js",
                      "~/Scripts/mobile-nav.js",
                      "~/Scripts/wow.min.js",
                      "~/Scripts/waypoints.min.js",
                      "~/Scripts/counterup/counterup.min.js",
                      "~/Scripts/owlcarousel/owl.carousel.min.js",
                      "~/Scripts/isotope/isotope.pkgd.min.js",
                      "~/Scripts/lightbox.min.js", 
                      "~/Scripts/main.js",
                      "~/Scripts/lightbox.min.js",
                      "~/Scripts/contactform.js",
                      "~/Scripts/angular/angular.js",
                      "~/Scripts/angular/angular-route.js",
                       "~/Scripts/ng-appController/InvesterController.js"

                      ));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/site.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/animate/animate.min.css",
                      "~/Content/ionicons/ionicons.min.css",
                      "~/Content/owlcarousel/assets/owl.carousel.min.css",
                      "~/Content/lightbox.min.css"));
        }
    }
}
