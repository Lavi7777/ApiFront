using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace APIFront.Models.Database
{
    public class Country
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        public string CountryName { get; set; } = string.Empty;
    }
}
