namespace HrDatabaseBackend.Model.JobPostingModel
{
    public interface IJobPostingDatabaseSetting
    {
        string JobPostingCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
