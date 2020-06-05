﻿using System;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Routing;
using ParkingMangement_API_Common;

namespace ParkingManagement_API_DAL
{
    public class CustomActionFilter : ActionFilterAttribute
    {
        Stopwatch stopWatch;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            stopWatch.Stop();
            Log(filterContext.RouteData, stopWatch.ElapsedMilliseconds);
        }

        private void Log(RouteData routeData, long time)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            TimeSpan t = TimeSpan.FromMilliseconds(time);
            string readabletime = string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
                                    t.Hours,
                                    t.Minutes,
                                    t.Seconds,
                                    t.Milliseconds);
            using (ParkingManagementContext contextdb = new ParkingManagementContext())
            {
                Actionlog log = new Actionlog()
                {
                    ControllerDescrption = controllerName.ToString(),
                    ActionExectionInfo = actionName.ToString(),
                    ExectionTime = readabletime.ToString()
                };
                contextdb.Actionlogs.Add(log);
                contextdb.SaveChanges();
            }
        }
    }

}