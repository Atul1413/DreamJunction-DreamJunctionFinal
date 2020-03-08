using System.Web;
using System.Web.Optimization;

namespace DreamJunction
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //backend JS
            bundles.Add(new ScriptBundle("~/bundles/backend-js").Include(
                        "~/Content/backend/js/modernizr-2.8.3.min.js",
                        "~/Content/backend/js/jquery-2.2.4.min.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/moment-with-locales.js",
                        "~/Scripts/bootstrap-select.js",
                        "~/Scripts/bar-chart.js",
                        "~/Scripts/bootstrap-datetimepicker.js",
                        "~/Scripts/jquery.slicknav.min.js",
                        "~/Scripts/jquery.slimscroll.min.js",
                        "~/Scripts/line-chart.js",
                        "~/Scripts/metisMenu.min.js",
                        "~/Scripts/owl.carousel.min.js",
                        "~/Scripts/pie-chart.js",
                        "~/Scripts/plugins.js",
                        "~/Scripts/popper.min.js",
                        "~/Scripts/scripts.js"
                        ));

            //backend CSS
            bundles.Add(new StyleBundle("~/bundles/backend-css").Include(
                       "~/Content/backend/css/bootstrap.min.css",
                       "~/Content/backend/css/font-awesome.min.css",
                       "~/Content/backend/css/bootstrap-select.css",
                       "~/Content/backend/css/bootstrap-datetimepicker.css",
                       "~/Content/backend/css/font-awesome.min.css",
                       "~/Content/backend/css/themify-icons.css",
                       "~/Content/backend/css/metisMenu.css",
                       "~/Content/backend/css/owl.carousel.min.css",
                       "~/Content/backend/css/slicknav.min.css",
                       "~/Content/backend/css/typography.css",
                       "~/Content/backend/css/default-css.css",
                       "~/Content/backend/css/styles.css",
                       "~/Content/backend/css/responsive.css"
                       ));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            //Front-End

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bs-stepper.min.js",
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

            //Front-end
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/site.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/animate/animate.min.css",
                      "~/Content/ionicons/ionicons.min.css",
                      "~/Content/owlcarousel/assets/owl.carousel.min.css",
                      "~/Content/lightbox.min.css",
                      "~/Content/noUiSlider/jquery.nouislider.css"));
        }
    }
}
