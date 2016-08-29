namespace Common.Configuration
{
    public interface IApplicationConfiguration
    {
        string MongoUserName { get; }
        string MongoPassword { get; }
        string PathfinderConnectionString { get; }
        string CharacterConnectionString { get; }
        string PathfinderDatabaseName { get; }
    }
}