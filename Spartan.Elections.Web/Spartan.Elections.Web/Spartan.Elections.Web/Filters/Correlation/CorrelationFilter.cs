using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Spartan.Elections.Web.Filters.Correlation
{
    public sealed class CorrelationFilter : IActionFilter
    {
        private static readonly string CorrelationIdHeader = "x-correlation-id";

        public void OnActionExecuted(ActionExecutedContext context) { }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.Request.Headers.ContainsKey(CorrelationIdHeader))
            {
                context.HttpContext.Request.Headers.Add(CorrelationIdHeader, Guid.NewGuid().ToString("d"));
            }
        }
    }
}
