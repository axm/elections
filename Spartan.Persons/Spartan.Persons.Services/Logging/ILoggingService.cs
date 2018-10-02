using System;

namespace Spartan.Persons.Services.Logging
{
    public interface ILoggingService
    {
        IDisposable Time();
    }

}
