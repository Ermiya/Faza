using System.Web.Http;
using ERP.PMS.Facade.Filters.Exception;

namespace ERP.PMS.Service.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
//            config.Filters.Add(new ExceptionHandlingMiddleware());
//            config.MessageHandlers.Add(new ExceptionHandlingMiddleware());
            config.Filters.Add(new ExceptionHandlingFilter());
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new {id = RouteParameter.Optional}
            );
            config.Routes.IgnoreRoute("exceptions.axd","");
            
            config.Filters.Add(new ExceptionHandlingFilter());
        }
    }
}