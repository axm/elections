using SimpleInjector;
using Validation;

namespace Spartan.Candidates.Service.Ioc
{
    public static class IocRegistration
    {
        public static Container AddCommandServices(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            return container;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="container"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="container"/> is null.</exception>
        public static Container AddQueryServices(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            return container;
        }
    }
}
