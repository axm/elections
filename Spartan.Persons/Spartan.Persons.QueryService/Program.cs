using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.ServiceFabric.Services.Runtime;
using SimpleInjector;
using Spartan.Mappings;
using Spartan.Persons.QueryService.Ioc;
using Spartan.Persons.QueryService.Mappings;

namespace Spartan.Persons.QueryService
{
    internal static class Program
    {
        /// <summary>
        /// This is the entry point of the service host process.
        /// </summary>
        private static void Main()
        {
            try
            {
                var container = new Container();
                container.AddQueryServices();

                ServiceRuntime.RegisterServiceAsync("Spartan.Persons.QueryServiceType",
                    context => new QueryService(context, container)).GetAwaiter().GetResult();

                ServiceEventSource.Current.ServiceTypeRegistered(Process.GetCurrentProcess().Id, typeof(QueryService).Name);

                // Prevents this host process from terminating so services keep running.
                Thread.Sleep(Timeout.Infinite);
            }
            catch (Exception e)
            {
                ServiceEventSource.Current.ServiceHostInitializationFailed(e.ToString());
                throw;
            }
        }
    }
}
