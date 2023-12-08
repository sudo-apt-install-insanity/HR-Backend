using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HrDatabaseBackend.Model.JobPostingModel
{
    [BsonIgnoreExtraElements]
    public class JobPosting
    {
        
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; } = String.Empty;


        [BsonElement("department")]
        public string department { get; set; } = String.Empty;

        [BsonElement("job_title")]
        public string job_title { get; set; } = String.Empty;

        [BsonElement("description")]
        public string description { get; set; }= String.Empty;

        [BsonElement("qualification_requirements")]
        public string qualification_requirements { get; set; }= String.Empty;

        [BsonElement("experience_requirements")]
        public string experience_requirements { get; set; }= String.Empty;

        [BsonElement("salary_range")]
        public string salary_range { get; set; }= String.Empty;

        [BsonElement("image_url")]
        public string image_url { get; set; }= String.Empty;
    }

  
}
