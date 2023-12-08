namespace HrDatabaseBackend.Model.ApplicantsModel
{
    public interface IApplicantsDatabaseSetting
    {
        string ApplicantsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
