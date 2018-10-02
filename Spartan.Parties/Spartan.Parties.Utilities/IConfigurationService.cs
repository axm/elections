namespace Spartan.Parties.Utilities
{
    public interface IConfigurationService
    {
        string GetConnectionString(string key);
    }
}
