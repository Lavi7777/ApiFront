using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace APIFront.Models.Database.AffiliateCampaign
{
    public class AutologinUrl
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
