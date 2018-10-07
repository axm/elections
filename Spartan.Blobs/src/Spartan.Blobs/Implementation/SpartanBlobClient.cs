using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Spartan.Blobs.Config;
using System;
using System.Threading.Tasks;

namespace Spartan.Blobs.Implementation
{
    public sealed class SpartanBlobClient : ISpartanBlobClient
    {
        private readonly IBlobConfigurationReader _reader;

        public SpartanBlobClient(IBlobConfigurationReader reader)
        {
            _reader = reader ?? throw new ArgumentNullException(nameof(reader));
        }

        /// <inheritdoc/> 
        public async Task<byte[]> DownloadToByteArrayAsync(ContainerBlob containerBlob)
        {
            var container = GetContaner(ref containerBlob);

            var blob = container.GetBlockBlobReference(containerBlob.BlobId);

            var bytes = Array.Empty<byte>();
            await blob.DownloadToByteArrayAsync(bytes, 0);

            return bytes;
        }

        /// <inheritdoc />
        public async Task UploadAsync(ContainerBlob containerBlob, byte[] contents)
        {
            if (contents == null)
            {
                throw new ArgumentNullException(nameof(contents));
            }

            var container = GetContaner(ref containerBlob);
            await container.CreateIfNotExistsAsync();

            var blob = container.GetBlockBlobReference(containerBlob.BlobId);
            await blob.UploadFromByteArrayAsync(contents, 0, contents.Length);
        }

        private CloudBlobContainer GetContaner(ref ContainerBlob containerBlob)
        {
            var blobClient = GetClient();
            return blobClient.GetContainerReference(containerBlob.Container);
        }

        private CloudBlobClient GetClient()
        {
            if (!CloudStorageAccount.TryParse(_reader.GetConnectionString(), out var storageAccount))
            {
                throw new InvalidOperationException();
            }

            var blobClient = storageAccount.CreateCloudBlobClient();
            return blobClient;
        }
    }
}
