using SimpleInjector;
using System.Configuration;
using Validation;

namespace Elections.Candidates.Data.Ioc
{
    public static class IocRegistration
    {
        private const string CandidatesConnectionKey = "CandidatesConnection";

        public static Container AddCandidatesRepository(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            var connectionString = ConfigurationManager.ConnectionStrings[CandidatesConnectionKey].ConnectionString;

            container.Register<ICandidatesRepository, CandidatesRepository>();
            container.Register<IDbContainer>(() => new DbContainer(connectionString));

            return container;
        }
    }
}
