using System;
using System.Net.Http.Headers;
using System.Web.Http.Filters;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingMangement_API_Common
{
    public class CacheFiltercs : ActionFilterAttribute
    {
        public int TimeDuration { get; set; }
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            actionExecutedContext.Response.Headers.CacheControl = new CacheControlHeaderValue
            {
                MaxAge = TimeSpan.FromSeconds(TimeDuration),
                MustRevalidate = true,
                Public = true
            };
        }
    }
}