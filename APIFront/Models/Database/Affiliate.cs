using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace APIFront.Models.Database
{
    public class Affiliate
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        public string AffiliateName { get; set; } = string.Empty;
    }
}
