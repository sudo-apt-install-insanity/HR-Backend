namespace HrDatabaseBackend.Model.PerformanceModel
{
    public interface IPerformanceDatabaseSetting
    {

        string PerformanceCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
