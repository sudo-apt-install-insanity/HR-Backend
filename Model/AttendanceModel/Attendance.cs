

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace HrDatabaseBackend.Model.AttendanceModel
{
    [BsonIgnoreExtraElements]
    public class Attendance
    {
          
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; } = String.Empty;

        [BsonElement("usertableid")]
        public string usertableid { get; set; }= String.Empty;

        [BsonElement("name")]
        public string name { get; set; }=String.Empty;

        [BsonElement("email")]
        public string email { get; set; } = String.Empty;

        [BsonElement("phone")]
        public string phone { get; set; } = String.Empty;

        [BsonElement("address")]
        public string address { get; set; } = String.Empty;

        [BsonElement("Department")]
        public string Department { get; set; } = String.Empty;

        [BsonElement("dateofhire")]
        public string dateofhire { get; set; } = String.Empty;

        [BsonElement("attendance")]
        public List<AttendanceRecord> attendance { get; set; }

        [BsonElement("leaveRequests")]
        public List<leave> leaveRequests { get; set; } 
    }

    public class leave
    {
        [BsonElement("startDate")]
        public string startDate { get; set; } = String.Empty;

        [BsonElement("endDate")]
        public string endDate { get; set; } = String.Empty;

        [BsonElement("reason")]
        public string reason { get; set; }=String.Empty;

        [BsonElement("status")]
        public string status { get; set; }=String.Empty;

    }
    public class AttendanceRecord
    {
        [BsonElement("date")]
        public string date { get; set; }=String.Empty;
        [BsonElement("status")]
        public string status { get; set; }=String.Empty;

        [BsonElement("clockin")]
        public string clockin { get; set; }= String.Empty;

        [BsonElement("clockout")]
        public string clockout { get; set; } = String.Empty;
    }
}


 

