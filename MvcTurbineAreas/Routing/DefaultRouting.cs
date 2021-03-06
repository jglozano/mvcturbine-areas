﻿
using System.Web.Mvc;
using System.Web.Routing;
using MvcTurbine.Routing;

namespace MvcTurbineAreas.Routing
{
    public class DefaultRouting : IRouteRegistrator
    {
        public void Register(RouteCollection routes)
        {
            AreaRegistration.RegisterAllAreas();

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
        }
    }
}