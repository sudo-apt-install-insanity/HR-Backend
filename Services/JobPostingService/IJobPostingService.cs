using HrDatabaseBackend.Model.JobPostingModel;

namespace HrDatabaseBackend.Services.JobPostingService
{
    public interface IJobPostingService
    {

        List<JobPosting> Get();

        JobPosting Get(string id);

        JobPosting Create(JobPosting student);
        void Update(string id, JobPosting student);
        void Remove(string id);
    }
}
