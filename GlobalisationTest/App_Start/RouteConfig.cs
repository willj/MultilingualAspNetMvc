using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GlobalisationTest
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{language}-{culture}/{controller}/{action}/{id}",
                defaults: new { language = "en", culture = "GB", controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "NoCulture",
                url: "{controller}/{action}/{id}",
                defaults: new { language = "en", culture = "GB", controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
