using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using ServiciosWeb.WebApi.CustomHandler;

namespace ServiciosWeb.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Services.Replace(typeof(IExceptionHandler), new GlobalExceptionHandler());

            config.Services.Replace(typeof(IExceptionLogger), new UnhandledExceptionLogger());

            config.MessageHandlers.Add(new RequestResponseHandler());

            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/v1/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
