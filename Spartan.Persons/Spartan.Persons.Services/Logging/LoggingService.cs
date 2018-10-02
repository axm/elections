using Spartan.Persons.Services.Utilities;
using System;
using System.Timers;

namespace Spartan.Persons.Services.Logging
{
    internal sealed class LoggingService : ILoggingService
    {
        public IDisposable Time()
        {
            var timer = new Timer();
            timer.Start();

            return Disposable.Create(() => LogTiming(timer));
        }

        private void LogTiming(Timer timer)
        {
            timer.Stop();
        }
    }
}
