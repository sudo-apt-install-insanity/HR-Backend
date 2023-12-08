namespace HrDatabaseBackend.Model.ApplicantsModel
{
    public class ApplicantsDatabaseSetting : IApplicantsDatabaseSetting
    {
      
        public string ConnectionString { get ; set; }
        public string DatabaseName { get; set ; }
        public string ApplicantsCollectionName { get; set ; }
    }
}
