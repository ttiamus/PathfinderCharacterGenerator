using MongoDB.Driver;

namespace Core.V2.Shared
{
    public abstract class AbstractMongoRepository<T>
    {
        protected readonly IMongoCollection<T> collection;

        protected AbstractMongoRepository(string connection, string databaseName, string collectionName)
        {
            var client = new MongoClient(connection);
            var database = client.GetDatabase(databaseName);
            collection = database.GetCollection<T>(collectionName);
        }
    }
}
