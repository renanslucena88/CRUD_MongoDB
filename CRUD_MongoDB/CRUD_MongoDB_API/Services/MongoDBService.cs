using CRUD_MongoDB_API.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUD_MongoDB_API.Services
{
    public class MongoDBService
    {
        //private MongoDB.Driver.Collation
        private IMongoCollection<ImportCSV> ImportCollection { get; }

        public MongoDBService(string dbUrl, string databaseName, string collectionName)
        {
            var mongoClient = new MongoClient(dbUrl);
            var mongoDatabase = mongoClient.GetDatabase(databaseName);
            ImportCollection = mongoDatabase.GetCollection<ImportCSV>(collectionName);
        }


        public async Task Insert(ImportCSV model)
        {
            await ImportCollection.InsertOneAsync(model);
        }

        public async Task<List<ImportCSV>> GetTopThousand()
        {
            var resultList = new List<ImportCSV>();
            var options = new FindOptions<ImportCSV, ImportCSV>
            {
                AllowPartialResults = false,
                Limit = 400000
            };
            var allDocs = await ImportCollection.FindAsync(new BsonDocument(), options);
            await allDocs.ForEachAsync(item => resultList.Add(item));
            return resultList;
        }

        public async Task<List<ImportCSV>> GetAll()
        {
            var resultList = new List<ImportCSV>();
            var allDocs = await ImportCollection.FindAsync(new BsonDocument());
            await allDocs.ForEachAsync(item => resultList.Add(item));
            return resultList;
        }
    }
}
