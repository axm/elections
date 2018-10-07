namespace Spartan.Blobs
{
    public struct ContainerBlob
    {
        public string Container { get; }
        public string BlobId { get; }

        public ContainerBlob(string container, string blobId)
        {
            Container = container;
            BlobId = blobId;
        }
    }
}