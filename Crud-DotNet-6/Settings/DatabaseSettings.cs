namespace Crud_DotNet_6.Settings
{
    public interface IDatabaseSettings
    {
        public string ConnectionString { get; set; }

        public string Database { get; set; }
    }

    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }

        public string Database { get; set; }
    }
}