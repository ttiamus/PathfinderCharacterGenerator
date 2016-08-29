using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.Configuration;
using Core.V2.Items.Models.Data;
using MongoDB.Driver;

namespace Core.V2.Shared
{
    public abstract class AbstractMongoRepository
    {
        protected readonly IMongoCollection<Item> collection;

        protected AbstractMongoRepository(string connection, string databaseName, string collectionName)
        {
            var client = new MongoClient(connection);
            var database = client.GetDatabase(databaseName);
            collection = database.GetCollection<Item>(collectionName);
        }
    }
}
