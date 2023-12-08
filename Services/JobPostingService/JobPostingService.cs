using HrDatabaseBackend.Model.JobPostingModel;
using MongoDB.Driver;

namespace HrDatabaseBackend.Services.JobPostingService
{
    public class JobPostingService : IJobPostingService
    {
        private readonly IMongoCollection<JobPosting> _jobposting;

        public JobPostingService(IJobPostingDatabaseSetting setting,IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(setting.DatabaseName);
            _jobposting = database.GetCollection<JobPosting>(setting.JobPostingCollectionName);


        }
        public JobPosting Create(JobPosting jobPosting)
        {
            _jobposting.InsertOne(jobPosting);
            return jobPosting;
        }

        public List<JobPosting> Get()
        {
            return _jobposting.Find(jobposting => true).ToList();
        }

        public JobPosting Get(string id)
        {
            return _jobposting.Find(jobposting => jobposting.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _jobposting.DeleteOne(jobposting => jobposting.Id == id);
        }

        public void Update(string id, JobPosting jobposting)
        {
            _jobposting.ReplaceOne(jobposting => jobposting.Id == id, jobposting);
        }
    }
}
