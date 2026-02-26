using _01_Api_Rest.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace _01_Api_Rest.Services
{
    public class AchatService
    {
        private readonly IMongoCollection<Achat> _achatCollection;

        public AchatService(
            IOptions<AchatDatabaseSettings> achatDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                achatDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                achatDatabaseSettings.Value.DatabaseName);

            _achatCollection = mongoDatabase.GetCollection<Achat>(
                achatDatabaseSettings.Value.AchatCollectionName);
        }

        // GET all items from database
        public async Task<List<Achat>> GetAsync() =>
            await _achatCollection.Find(_ => true).ToListAsync();

        // GET Single item from database
        public async Task<Achat?> GetAsync(string id) =>
            await _achatCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        // ADD single item to database
        public async Task CreateAsync(Achat newAchat) =>
            await _achatCollection.InsertOneAsync(newAchat);

        // UPDATE single item 
        public async Task UpdateAsync(string id, Achat updatedAchat) =>
            await _achatCollection.ReplaceOneAsync(x => x.Id == id, updatedAchat);

        // DELETE single item
        public async Task RemoveAsync(string id) =>
            await _achatCollection.DeleteOneAsync(x => x.Id == id);
    }
}
