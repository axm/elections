namespace Spartan.Persons.Data.Blob
{
    public sealed class BlobRepository : IBlobRepository
    {
        public T ReadAsync<T>(string container, string blobId)
        {
            throw new System.NotImplementedException();
        }
    }
}
