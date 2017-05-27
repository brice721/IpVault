using System.Web.Http;

namespace API_Attempt
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // New Code
            config.EnableCors();

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new {id = RouteParameter.Optional}
            );
        }
    }
}