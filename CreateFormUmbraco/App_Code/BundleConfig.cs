using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using Umbraco.Core;

/// <summary>
/// Summary description for BundleConfig
/// </summary>
public class BundleConfig : IApplicationEventHandler
{
    public void OnApplicationInitialized(UmbracoApplicationBase umbracoApplication,
           ApplicationContext applicationContext)
    { }

    public void OnApplicationStarting(UmbracoApplicationBase umbracoApplication,
        ApplicationContext applicationContext)
    {
        BundleTable.Bundles.UseCdn = true;

        var jqueryCdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.1.min.js";

        BundleTable.Bundles.Add(new ScriptBundle("~/bundles/CDN", jqueryCdnPath).Include(
            "~/scripts/jquery-{version}.js"));

        BundleTable.Bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
            "~/scripts/jquery-{version}.js",
            "~/scripts/jquery-1.7.2.min.js",
            "~/scripts/jquery.validate.js"));

        BundleTable.Bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            "~/Scripts/jquery.unobtrusive*",
            "~/Scripts/jquery.validate*"));

        BundleTable.Bundles.Add(new StyleBundle("~/bundles/css").IncludeDirectory(
            "~/css/", "*.css"));
    }

    public void OnApplicationStarted(UmbracoApplicationBase umbracoApplication,
        ApplicationContext applicationContext)
    { }
}