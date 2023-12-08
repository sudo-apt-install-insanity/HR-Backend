
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace HrDatabaseBackend.Model.EmployeeModel
{
    [BsonIgnoreExtraElements]
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; } = String.Empty;


        [BsonElement("first_name")]
        public string FirstName { get; set; } = String.Empty;
        [BsonElement("last_name")]
        public string LastName { get; set; } = String.Empty;
       
        [BsonElement("date_of_birth")]
        public string DateOfStudent { get; set; }=String.Empty;

        [BsonElement("department")]
        public string Department { get; set; } = String.Empty;

        [BsonElement("job_title")]
        public string JobTitle {  get; set; } = String.Empty;
        [BsonElement("email")]
        public string Email { get; set; }= String.Empty;

        [BsonElement("phone")]
        public string Phone { get; set; } = String.Empty;

        [BsonElement("address")]
        public string Address { get; set; } = String.Empty;
        [BsonElement("start_date")]

        public string StartDate { get; set; } = String.Empty;

        [BsonElement("salary")]
        public int Salary { get; set; }
        [BsonElement("resume")]
        public string Resume { get; set; } = String.Empty;


        [BsonElement("identification")]
        public string Identification { get; set; } = String.Empty;


        [BsonElement("certificates")]
        public string[]?Certifcates { get; set; }

        



       


    }
}
