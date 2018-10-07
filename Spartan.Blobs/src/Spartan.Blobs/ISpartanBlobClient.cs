using System;
using System.Threading.Tasks;

namespace Spartan.Blobs
{
    public interface ISpartanBlobClient
    {
        Task UploadAsync(ContainerBlob containerBlob, byte[] contents);
        Task<byte[]> DownloadToByteArrayAsync(ContainerBlob containerBlob);
    }
}
