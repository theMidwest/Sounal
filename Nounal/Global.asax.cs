using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;

namespace Nounal
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);





        }


		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				"Default",                                              // Route name 
				"{controller}/{action}/{id}",                           // URL with parameters 
				new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
			);

		}

		

    }
}
