using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace APIFront.Models.Database.AffiliateCampaign
{
    public class AffiliateCampaign
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Description { get; set; } = string.Empty;
        public string CompanyId { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string BrandId { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;

        public string CompanyAffId { get; set; } = string.Empty;
        public string CompanyAff { get; set; } = string.Empty;
        public string AffId { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public bool Active { get; set; }
        public decimal LeadPriority { get; set; }

        public int HourlyLimit { get; set; }
        public int DailyLimit { get; set; }
        public int Interval { get; set; }
        public int Timeout { get; set; }

        public int CPA { get; set; }
        public int CPL { get; set; }
        public int CG { get; set; }


        public string AutologinUrl { get; set; } = string.Empty;


        public bool SkipMismatchedCountry { get; set; }
        public bool SkipDuplicate { get; set; }
        public bool SkipInvalidPhone { get; set; }
        public bool SkipInvalidEmail { get; set; }
        public bool CheckDuplicate { get; set; }
        public bool CheckGlobalDuplicateEmail { get; set; }
        public bool CheckGlobalDuplicatePhone { get; set; }

        public bool OnlyFallback { get; set; }

        public bool ConfirmDeposit { get; set; }

        public int CountConfirmDeposit { get; set; }

        public List<string> DisallowAreaCode { get; set; } = new List<string>();
        public List<string> AllowedFunnel { get; set; } = new List<string>();
        public List<string> DisallowedFunnel { get; set; } = new List<string>();
        public List<string> AllowedSource { get; set; } = new List<string>();

        public List<string> AllowedAreaCode { get; set; } = new List<string>();

        public List<string> DisalowedSource { get; set; } = new List<string>();

        
        public ICollection<WorkPeriod> WorkingHours { get; set; } = new List<WorkPeriod>();

       
        public ICollection<Param> Params { get; set; } = new List<Param>();
    }
}
