using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace APIFront.Models.Database
{
    public class Brand
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        public string BrandName { get; set; } = string.Empty;
    }
}
