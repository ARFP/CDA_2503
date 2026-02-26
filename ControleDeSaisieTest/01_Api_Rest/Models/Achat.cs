using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Security;

namespace _01_Api_Rest.Models
{
    public class Achat
    {
        [BsonId]
        // [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Nom { get; set; }

        public DateTime Date { get; set; }

        public decimal Montant { get; set; }

        public string CodePostal { get; set; }
    }
}


