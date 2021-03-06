﻿using Common.Bundles;
using System.Web.Optimization;

namespace Backoffice
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Enable bundling optimizations, even when the site is in debug mode or local.
            BundleTable.EnableOptimizations = true;


            // Bundle the jQuery Validation plugins
            var jqueryValidationScripts = new ScriptBundle("~/bundles/scripts/jquery-validate");
            jqueryValidationScripts.Include(
                "~/Content/scripts/vendor/jquery.validate.js",
                "~/Content/scripts/vendor/jquery.validate.config.js",
                "~/Content/scripts/vendor/jquery.validate.unobtrusive.js",
                "~/Content/scripts/vendor/jquery.validate.unobtrusive.custom.js",
                "~/Content/scripts/vendor/jquery.unobtrusive-ajax.js");

            bundles.Add(jqueryValidationScripts);


            // Bundle the Handlebars plugins
            var handlebarsScripts = new ScriptBundle("~/bundles/scripts/handlebars");
            handlebarsScripts.Include(
                "~/Content/scripts/vendor/handlebars.js",
                "~/Content/scripts/vendor/handlebars.extended.js");

            bundles.Add(handlebarsScripts);


            // Bundle the vendor's styles
            var vendorStyles = new StyleBundle("~/bundles/styles/vendor");
            vendorStyles.Include("~/Content/scripts/vendor/kendo/styles/kendo.common-bootstrap.min.css", new CssRewriteUrlTransformer());
            vendorStyles.Include("~/Content/scripts/vendor/kendo/styles/kendo.bootstrap.min.css", new CssRewriteUrlTransformer());
            vendorStyles.Include("~/Content/scripts/vendor/jquery.passwordstrength/jquery.passwordstrength.css", new CssRewriteUrlTransformer());
            vendorStyles.Include("~/Content/scripts/vendor/jorgchart/jquery.jOrgChart.css", new CssRewriteUrlTransformer());

            bundles.Add(vendorStyles);
        }
    }
}