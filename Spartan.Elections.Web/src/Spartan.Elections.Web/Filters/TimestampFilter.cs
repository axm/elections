using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Spartan.Elections.Web.Filters
{
    public sealed class TimestampFilter : IActionFilter
    {
        private readonly string TimestampHeader = "x-timestamp";

        public void OnActionExecuted(ActionExecutedContext context) { }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if(!context.HttpContext.Request.Headers.ContainsKey(TimestampHeader))
                context.HttpContext.Request.Headers.Add(TimestampHeader, DateTimeOffset.Now.ToString());
        }
    }
}
