﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EcoDriving
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "SingleAnalyze",
                "Analyze/Drives/Selected/{id}/{driveNum}",
                new { controller = "Analyze", action = "SingleAnalyze", id = 1, driveNum = 1 }
            );

            routes.MapRoute(
                "DoubleAnalyze",
                "Analyze/Drives/Selected/{id}/{driveNum}/{id2}/{driveNum2}",
                new { controller = "Analyze", action = "DoubleAnalyze", id = 1, driveNum = 1 , id2 = 1, driveNum2 = 1}
            );

            //routes.MapRoute(
            //    "SelectedDrive",
            //    "Home/Drives/Selected/{id}/{driveNum}",
            //    new { controller = "Home", action = "SelectedDrive", id = 1 }
            //);

            routes.MapRoute(
                "DrivesList",
                "Home/Drives/List/{id}",
                new { controller = "Home", action = "DriveList", id = 1 }
            );

            routes.MapRoute(
                "CoursantsList",
                "Home/Coursants/List",
                new { controller = "Home", action = "CoursantList" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}