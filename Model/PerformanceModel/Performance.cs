
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace HrDatabaseBackend.Model.PerformanceModel
{

    [BsonIgnoreExtraElements]
    public class Performance
    {

       


        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; } = String.Empty;

        [BsonElement("employee_id")]
        public string employee_id { get; set; } = String.Empty;


        [BsonElement("description")]
        public string description { get; set; } = String.Empty;
        [BsonElement("status")]
        public string status { get; set; } = String.Empty;

        [BsonElement("employeerating")]
        public string employeerating { get; set; } = String.Empty;


        [BsonElement("daily_goals")]
        public List<DailyGoal> daily_goals { get; set; }
    }


    public class DailyGoal
    {
      
        [BsonElement("date")]
        public string date { get; set; } = String.Empty;

        [BsonElement("description")]
        public string description { get; set; } = String.Empty;
    }
}
