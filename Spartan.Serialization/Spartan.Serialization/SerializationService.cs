using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Spartan.Serialization
{
    public sealed class SerializationService : ISerializationService
    {
        public byte[] ToByteArray<T>(T obj) where T : class
        {
            var bf = new BinaryFormatter();
            using (var stream = new MemoryStream())
            {
                bf.Serialize(stream, obj);
                return stream.ToArray();
            }
        }

        public string ToString<T>(T obj) where T : class => JsonConvert.SerializeObject(obj);
    }
}
