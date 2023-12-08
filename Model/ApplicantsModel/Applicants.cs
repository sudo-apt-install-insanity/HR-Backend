using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;


namespace HrDatabaseBackend.Model.ApplicantsModel
{
    [BsonIgnoreExtraElements]
    public class Applicants
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }=String.Empty;

        [BsonElement("job_postings_id")]
        public string job_postings_id { get; set; }= String.Empty;

        [BsonElement("full_name")]
        public string full_name { get; set; } = String.Empty;
        [BsonElement("resume")]
        public string resume { get; set; } = String.Empty;
        [BsonElement("email")]
        public string email { get; set; } = String.Empty;
        [BsonElement("phone_number")]
        public string Phone_Number { get; set; } = String.Empty;
        [BsonElement("address")]
        public string address { get; set; } = String.Empty;
        [BsonElement("education")]
        public string education { get; set; } = String.Empty;
        [BsonElement("work_experience")]
        public string work_experience { get; set; } = String.Empty;
        [BsonElement("cover_letter")]
        public string cover_letter { get; set; } = String.Empty;
        [BsonElement("status")]
        public string status { get; set; } = String.Empty;
        [BsonElement("date_applied")]
        public DateTime date_applied { get; set; }
    }
}



