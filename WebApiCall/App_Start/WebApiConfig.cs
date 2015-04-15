using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Formatting;

namespace WebApiCall
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            /* Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();*/

            config.Routes.MapHttpRoute(
                name: "Api UriPathExtension",
                routeTemplate: "api/{controller}.{extension}/{id}",
                defaults: new { id = RouteParameter.Optional, extension = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
              name: "Api UriPathExtension ID",
              routeTemplate: "api/{controller}/{id}.{extension}",
              defaults: new { id = RouteParameter.Optional, extension = RouteParameter.Optional }
            ); 

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.XmlFormatter.AddUriPathExtensionMapping("xml", "text/xml");
            config.Formatters.JsonFormatter.AddUriPathExtensionMapping("json", "application/json");
        }
    }
}
