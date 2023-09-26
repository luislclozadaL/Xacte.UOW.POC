using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Xacte.Web.NETF.App_Start;

namespace Xacte.Web.NETF
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            DependencyResolver.Initialize(config);
        }
    }
}
