using HrDatabaseBackend.Model.ApplicantsModel;
using HrDatabaseBackend.Model.EmployeeModel;

using HrDatabaseBackend.Services.ApplicantsService;
using MongoDB.Driver;

namespace HrDatabaseBackend.Services.ApplicantsModel
{ 



    public class ApplicantsService : IApplicantsService
    {
        private readonly IMongoCollection<Applicants> _user;

        public ApplicantsService(IApplicantsDatabaseSetting applicantsDatabaseSetting, IMongoClient mongoClient)
    {
            var database = mongoClient.GetDatabase(applicantsDatabaseSetting.DatabaseName);
            _user = database.GetCollection<Applicants>(applicantsDatabaseSetting.ApplicantsCollectionName);
        }
    public Applicants Create(Applicants user)
        {
            _user.InsertOne(user);
            return user;
        }

        public List<Applicants> Get()
        {
            return _user.Find(user => true).ToList();
        }

        public Applicants Get(string id)
        {
            return _user.Find(_user => _user.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _user.DeleteOne(_user => _user.Id == id);
        }

        public void Update(string id, Applicants user)
        {
          _user.ReplaceOne(user => user.Id == id, user);
        }
    }
}
