using System.Web.Mvc;
using System.Web.Routing;

namespace TvShows
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Show",
				url: "Shows/Show/{id}",
				defaults: new { controller = "Shows", action = "Show" }
			);

			routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" }
            );
        }
    }
}
