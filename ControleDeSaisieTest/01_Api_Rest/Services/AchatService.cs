using Microsoft.Extensions.Options;
using MongoDB.Driver;
using _01_Api_Rest.Models;

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

        public async Task<List<Achat>> GetAsync() =>
            await _achatCollection.Find(_ => true).ToListAsync();

        public async Task<Achat?> GetAsync(string id) =>
            await _achatCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Achat newAchat) =>
            await _achatCollection.InsertOneAsync(newAchat);

        public async Task UpdateAsync(string id, Achat updatedAchat) =>
            await _achatCollection.ReplaceOneAsync(x => x.Id == id, updatedAchat);

        public async Task RemoveAsync(string id) =>
            await _achatCollection.DeleteOneAsync(x => x.Id == id);
    }
}
