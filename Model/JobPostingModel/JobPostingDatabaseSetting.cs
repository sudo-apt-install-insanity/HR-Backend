namespace HrDatabaseBackend.Model.JobPostingModel
{
    public class JobPostingDatabaseSetting : IJobPostingDatabaseSetting
    {
        public string JobPostingCollectionName { get ; set ; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set ; }
    }
}
