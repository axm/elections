using System;

namespace Spartan.Elections.Web.Attributes
{
    public sealed class ApiContextAttribute : Attribute
    {
        public string ApiContext { get; }

        public ApiContextAttribute(string apiContext)
        {
            ApiContext = apiContext;
        }
    }
}
