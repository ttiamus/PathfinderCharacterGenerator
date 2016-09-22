namespace Common.Configuration.EnvironmentConfiguration
{
    public interface IEnvironmentConfiguration
    {
        string MongoUserName { get; }
        string MongoPassword { get; }
        string PathfinderConnectionString { get; }
        string PathfinderDatabaseName { get; }
    }
}