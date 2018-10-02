namespace Spartan.Persons.Types
{
    public static class ServiceUris
    {
        private const string RootUri = "fabric:/Spartan.Persons.Fabric";

        public static string PersonsCommandService => $"{RootUri}/Spartan.Persons.CommandService";
    }
}
