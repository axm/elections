using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Spartan.Serialization
{
    public sealed class SerializationService : ISerializationService
    {
        private static JsonSerializer Serializer => _Serializer.Value;
        private static Lazy<JsonSerializer> _Serializer = new Lazy<JsonSerializer>(CreateDefaultSerializer);

        private static JsonSerializer CreateDefaultSerializer()
        {
            var settings = new JsonSerializerSettings();
            settings.Formatting = Formatting.None;
            settings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;

            var jsonSerializer = JsonSerializer.Create();

            return jsonSerializer;
        }

        /// <inheritdoc />
        public T Deserialize<T>(byte[] bytes) where T : class
        {
            using (var stream = new MemoryStream(bytes))
            using (var reader = new StreamReader(stream, Encoding.UTF8))
                return Serializer.Deserialize(reader, typeof(T)) as T;
        }

        /// <inheritdoc />
        public byte[] ToByteArray<T>(T obj) where T : class
        {
            using (var stream = new MemoryStream())
            using (var writer = new StreamWriter(stream, Encoding.UTF8))
            {
                Serializer.Serialize(writer, obj);

                return stream.ToArray();
            }
        }

        /// <inheritdoc />
        public string ToString<T>(T obj) where T : class => JsonConvert.SerializeObject(obj);
    }
}
