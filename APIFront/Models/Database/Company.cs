using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace APIFront.Models.Database
{
    public class Company
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
       
    }
}
