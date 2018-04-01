using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapMvcAttributeRoutes();
            ///*routes.maproute(
            //    name: "myroute",
            //    url: "movie/release/{year}/{month}",
            //    defaults: new { controller = "movie", action = "releasedate"},
            //    constraints:new { year = "\\d{4}", month = "\\d{2}" }
            //);*/
        }
    }
}
