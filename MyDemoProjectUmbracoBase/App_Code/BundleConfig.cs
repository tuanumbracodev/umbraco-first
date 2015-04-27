using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using Umbraco.Core;
using Umbraco.Web.Mvc;

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
        /*Get All js, css*/
        BundleTable.Bundles.Add(new ScriptBundle("~/bundles/scripts").IncludeDirectory("~/scripts/", "*.js"));

        BundleTable.Bundles.Add(new StyleBundle("~/bundles/css").IncludeDirectory("~/css/", "*.css"));

        BundleTable.Bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            "~/scripts/jquery.unobtrusive*",
            "~/scripts/jquery.validate*"));

        /*Don't get some js, css*/
        BundleTable.Bundles.IgnoreList.Ignore("*-inactive.js", OptimizationMode.Always);
        BundleTable.Bundles.IgnoreList.Ignore("*-inactive.css", OptimizationMode.Always);
        
    }

    public void OnApplicationStarted(UmbracoApplicationBase umbracoApplication,
        ApplicationContext applicationContext)
    { }
}