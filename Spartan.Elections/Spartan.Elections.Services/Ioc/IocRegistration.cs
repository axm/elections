using SimpleInjector;
using Spartan.Azure.Blobs.Ioc;
using Spartan.Elections.Services.Elections;
using Spartan.Elections.Services.Elections.Implementation;
using Spartan.Elections.Services.Templates;
using Spartan.Elections.Services.Templates.Implementation;

namespace Spartan.Elections.Services.Ioc
{
    public static class IocRegistration
    {
        public static Container AddDependencies(this Container container)
        {
            container.Register<IElectionsService, ElectionsService>();
            container.Register<IElectionTemplatesService, ElectionTemplatesService>();

            return container;
        }
    }
}
