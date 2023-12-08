namespace HrDatabaseBackend.Model.PerformanceModel
{
    public class PerformanceDatabaseSetting : IPerformanceDatabaseSetting
    {
        public string PerformanceCollectionName { get; set; }
        public string ConnectionString { get; set ; }
        public string DatabaseName { get; set; }
    }
}
