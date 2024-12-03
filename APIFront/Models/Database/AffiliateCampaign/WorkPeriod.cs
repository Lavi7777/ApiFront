using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace APIFront.Models.Database.AffiliateCampaign
{
    public class WorkPeriod
    {
      
        public string DayOfWeek { get; set; } = string.Empty;
        public ICollection<WorkTimePeriod> WorkTime { get; set; } = new List<WorkTimePeriod>();
    }
}
