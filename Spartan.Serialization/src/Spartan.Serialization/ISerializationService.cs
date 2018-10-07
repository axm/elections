namespace Spartan.Serialization
{
    public interface ISerializationService
    {
        string ToString<T>(T obj) where T: class;
        byte[] ToByteArray<T>(T obj) where T: class;
        T Deserialize<T>(byte[] bytes) where T : class;
    }
}
