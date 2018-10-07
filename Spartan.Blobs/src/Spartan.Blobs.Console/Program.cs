using Spartan.Blobs.Config.Implementation;
using Spartan.Blobs.Implementation;
using System;
using System.Threading.Tasks;

namespace Spartan.Blobs.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var blobClient = new SpartanBlobClient(new BlobConfigurationReader());
            await blobClient.UploadAsync(new ContainerBlob("voting", "somevote.json"), Array.Empty<byte>());
        }
    }
}
