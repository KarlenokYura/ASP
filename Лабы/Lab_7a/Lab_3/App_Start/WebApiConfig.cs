﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Lab_3
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "TS/{id}",
                defaults: new { controller = "TS", id = RouteParameter.Optional }
            );
        }
    }
}
