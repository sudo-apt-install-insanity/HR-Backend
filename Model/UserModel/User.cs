
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace HrDatabaseBackend.Model.UserModel
{

    [BsonIgnoreExtraElements]
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public String Id { get; set; } = String.Empty;
        [BsonElement("userid")]
        public int userid { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }= String.Empty;
        [BsonElement("password")]
        public string Password { get; set; }=String.Empty;

        [BsonElement("first_name")]
        public string FirstName { get; set; }=String.Empty;

        [BsonElement("last_name")]
        public string LastName { get; set; } = String.Empty;
        [BsonElement("role")]
        public string Role { get; set; }=String.Empty;





    }
}
