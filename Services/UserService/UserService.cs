using HrDatabaseBackend.Model.UserModel;
using MongoDB.Driver;
using System.Data;

namespace HrDatabaseBackend.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IMongoCollection<User> _user;

        public UserService(IUserDatabaseSetting userDatabaseSetting, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(userDatabaseSetting.DatabaseName);
           _user=database.GetCollection<User>(userDatabaseSetting.UserCollectionName);
 
        } public User Create(User user)
        {
            _user.InsertOne(user);
            return user;
        }

        public List<User> Get()
        {
            return _user.Find(user => true).ToList();
        }

        public User Get(string id)
        {
            return _user.Find(_user => _user.Id == id).FirstOrDefault();

        }
    
        public void Remove(string id)
        {
            _user.DeleteOne(_user => _user.Id == id);
        }

        public void Update(string id, User user)
        {
            _user.ReplaceOne(user => user.Id == id, user);

        }
    }
}
