using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Spartan.Elections.Web.Api.v1.Middleware
{
    public class FeatureSwitchMiddleware
    {
        private RequestDelegate RequestDelegate { get; }

        public FeatureSwitchMiddleware(RequestDelegate requestDelegate)
        {
            RequestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context) => await RequestDelegate?.Invoke(context);
    }
}
