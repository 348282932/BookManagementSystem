using System.Web.Optimization;

namespace BookManagementSystem.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            //VENDOR RESOURCES

            //~/Bundles/vendor/css
            bundles.Add(
                new StyleBundle("~/Bundles/vendor/css")
                    .Include("~/Content/themes/base/all.css", new CssRewriteUrlTransform())
                    .Include("~/Content/bootstrap-cosmo.min.css", new CssRewriteUrlTransform())
                    .Include("~/Content/toastr.min.css", new CssRewriteUrlTransform())
                    .Include("~/Scripts/sweetalert/sweet-alert.css", new CssRewriteUrlTransform())
                    .Include("~/Content/flags/famfamfam-flags.css", new CssRewriteUrlTransform())
                    .Include("~/Content/font-awesome.min.css", new CssRewriteUrlTransform())
                );

            //~/Bundles/vendor/js/top (These scripts should be included in the head of the page)
            bundles.Add(
                new ScriptBundle("~/Bundles/vendor/js/top")
                    .Include(
                        "~/Abp/Framework/scripts/utils/ie10fix.js",
                        "~/Scripts/modernizr-2.8.3.js"
                    )
                );

            //~/Bundles/vendor/bottom (Included in the bottom for fast page load)
            bundles.Add(
                new ScriptBundle("~/Bundles/vendor/js/bottom")
                    .Include(
                        "~/Scripts/json2.min.js",

                        "~/Scripts/jquery-2.2.0.min.js",
                        "~/Scripts/jquery-ui-1.11.4.min.js",

                        "~/Scripts/bootstrap.min.js",

                        "~/Scripts/moment-with-locales.min.js",
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.blockUI.js",
                        "~/Scripts/toastr.min.js",
                        "~/Scripts/sweetalert/sweet-alert.min.js",
                        "~/Scripts/others/spinjs/spin.js",
                        "~/Scripts/others/spinjs/jquery.spin.js",

                        "~/Abp/Framework/scripts/abp.js",
                        "~/Abp/Framework/scripts/libs/abp.jquery.js",
                        "~/Abp/Framework/scripts/libs/abp.toastr.js",
                        "~/Abp/Framework/scripts/libs/abp.blockUI.js",
                        "~/Abp/Framework/scripts/libs/abp.spin.js",
                        "~/Abp/Framework/scripts/libs/abp.sweet-alert.js",

                        "~/Scripts/jquery.signalR-2.2.1.min.js"
                    )
                );

            bundles.Add(
                new StyleBundle("~/Bundles/amazeui/css")
                    .Include("~/assets/css/amazeui.min.css", new CssRewriteUrlTransform())
                    .Include("~/assets/css/amazeui.datatables.min.css", new CssRewriteUrlTransform())
                    .Include("~/assets/css/app.css", new CssRewriteUrlTransform())
                    //.Include("~/css/admin.css", new CssRewriteUrlTransform())
                    .Include("~/assets/css/fullcalendar.min.css", new CssRewriteUrlTransform())
                    .Include("~/assets/css/fullcalendar.print.css", new CssRewriteUrlTransform())
                );

            bundles.Add(
                new ScriptBundle("~/Bundles/amazeui/js")
                    .Include(
                        "~/assets/js/theme.js",
                        "~/assets/js/amazeui.min.js",
                        "~/assets/js/amazeui.datatables.min.js",
                        "~/assets/js/dataTables.responsive.min.js",
                        "~/assets/js/fullcalendar.min.js",
                        "~/assets/js/app.js"
                    //"~/js/moment.js",
                    //"~/js/theme.js"
                    )
                );

            bundles.Add(
                new StyleBundle("~/Bundles/amazeui/login/css")
                    .Include("~/assets/css/amazeui.min.css", new CssRewriteUrlTransform())
                    .Include("~/assets/css/amazeui.datatables.min.css", new CssRewriteUrlTransform())
                    .Include("~/assets/css/app.css", new CssRewriteUrlTransform())
                    .Include("~/Views/Account/Login.css", new CssRewriteUrlTransform())
                );
            bundles.Add(
                new ScriptBundle("~/Bundles/amazeui/login/js")
                    .Include(
                        "~/assets/js/amazeui.min.js",
                        "~/assets/js/theme.js",
                        "~/assets/js/app.js",
                        "~/Views/Account/Login.js"
                    )
                );

            

            //APPLICATION RESOURCES

            //~/Bundles/css
            bundles.Add(
                new StyleBundle("~/Bundles/css")
                    .Include("~/css/main.css")
                );

            //~/Bundles/js
            bundles.Add(
                new ScriptBundle("~/Bundles/js")
                    .Include("~/js/main.js")
                );
        }
    }
}