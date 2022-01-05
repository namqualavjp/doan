using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace doan.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundle)
        {
            //Add CSS layoutPublic------

            bundle.Add(new StyleBundle("~/bundle/css1").Include("~/Content/material-design-iconic-font.min.css",
                                                               "~/Content/font-awesome.min.css",
                                                               "~/Content/fontawesome-stars.css",
                                                               "~/Content/meanmenu.css",
                                                               "~/Content/owl.carousel.min.css",
                                                               "~/Content/slick.css",
                                                               "~/Content/animate.css",
                                                               "~/Content/jquery-ui.min.css",
                                                               "~/Content/venobox.css",
                                                               "~/Content/nice-select.css",
                                                               "~/Content/magnific-popup.css",
                                                               "~/Content/bootstrap.min.css",
                                                               "~/Content/helper.css",
                                                               "~/Content/style.css",
                                                               "~/Content/responsive.css"));
            //Add CSS layoutPrivate----
              
            bundle.Add(new StyleBundle("~/bundle/css2").Include("~/Content/font-face.css",
                                                                "~/Content/vendor/font-awesome-4.7/css/font-awesome.min.css",
                                                                "~/Content/vendor/font-awesome-5/css/fontawesome-all.min.css",
                                                                "~/Content/vendor/mdi-font/css/material-design-iconic-font.min.css",
                                                                "~/Content/vendor/bootstrap-4.1/bootstrap.min.css",
                                                                "~/Content/vendor/animsition/animsition.min.css",
                                                                "~/Content/vendor/bootstrap-progressbar/bootstrap-progressbar-3.3.4.min.css",
                                                                "~/Content/vendor/wow/animate.css",
                                                                "~/Content/vendor/css-hamburgers/hamburgers.min.css",
                                                                "~/Content/vendor/slick/slick.css",
                                                                "~/Content/vendor/select2/select2.min.css",
                                                                "~/Content/vendor/perfect-scrollbar/perfect-scrollbar.css",
                                                                "~/Content/theme.css"));
            //Add Scripts layoutPublic--------

            bundle.Add(new ScriptBundle("~/bundleS/moder").Include("~/Scripts/vendor/modernizr-2.8.3.min.js"));
            bundle.Add(new ScriptBundle("~/bundleS/scripts1").Include("~/Scripts/vendor/jquery-1.12.4.min.js",
                                                                      "~/Scripts/vendor/popper.min.js",
                                                                      "~/Scripts/bootstrap.min.js",
                                                                      "~/Scripts/ajax-mail.js",
                                                                      "~/Scripts/jquery.meanmenu.min.js",
                                                                      "~/Scripts/wow.min.js",
                                                                      "~/Scripts/slick.min.js",
                                                                      "~/Scripts/owl.carousel.min.js",
                                                                      "~/Scripts/jquery.magnific-popup.min.js",
                                                                      "~/Scripts/isotope.pkgd.min.js",
                                                                      "~/Scripts/imagesloaded.pkgd.min.js",
                                                                      "~/Scripts/jquery.mixitup.min.js",
                                                                      "~/Scripts/jquery.countdown.min.js",
                                                                      "~/Scripts/jquery.counterup.min.js",
                                                                      "~/Scripts/waypoints.min.js",
                                                                      "~/Scripts/jquery.barrating.min.js",
                                                                      "~/Scripts/jquery-ui.min.js",
                                                                      "~/Scripts/venobox.min.js",
                                                                      "~/Scripts/jquery.nice-select.min.js",
                                                                      "~/Scripts/scrollUp.min.js",
                                                                      "~/Scripts/main.js"));
            //Add Scripts layoutPrivate---

            bundle.Add(new ScriptBundle("~/bundleS/scripts2").Include("~/Content/vendor/jquery-3.2.1.min.js",
                                                                      "~/Content/vendor/bootstrap-4.1/popper.min.js",
                                                                      "~/Content/vendor/bootstrap-4.1/bootstrap.min.js",
                                                                      "~/Content/vendor/slick/slick.min.js",
                                                                      "~/Content/vendor/wow/wow.min.js",
                                                                      "~/Content/vendor/animsition/animsition.min.js",
                                                                      "~/Content/vendor/bootstrap-progressbar/bootstrap-progressbar.min.js",
                                                                      "~/Content/vendor/counter-up/jquery.waypoints.min.js",
                                                                      "~/Content/vendor/counter-up/jquery.counterup.min.js",
                                                                      "~/Content/vendor/circle-progress/circle-progress.min.js",
                                                                      "~/Content/vendor/perfect-scrollbar/perfect-scrollbar.js",
                                                                      "~/Content/vendor/chartjs/Chart.bundle.min.js",
                                                                      "~/Content/vendor/select2/select2.min.js",
                                                                      "~/Scripts/vendor/main.js"));
        }
    }
}