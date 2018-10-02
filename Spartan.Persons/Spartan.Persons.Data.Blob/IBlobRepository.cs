using System;

namespace Spartan.Persons.Data.Blob
{
    public interface IBlobRepository
    {
        T ReadAsync<T>(string container, string blobId);
    }
}
