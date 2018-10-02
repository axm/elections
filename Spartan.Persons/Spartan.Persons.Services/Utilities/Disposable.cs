using System;
using Validation;

namespace Spartan.Persons.Services.Utilities
{
    public static class Disposable
    {
        public static IDisposable Create(Action action)
        {
            Requires.NotNull(action, nameof(action));

            return new ThrowawayDisposable(action);
        }

        private class ThrowawayDisposable : IDisposable
        {
            private readonly Action _action;

            public ThrowawayDisposable(Action action)
            {
                _action = action;
            }

            public void Dispose()
            {
                _action();
            }
        }
    }
}
