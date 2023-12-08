namespace HrDatabaseBackend.Model.AttendanceModel
{
    public class AttendanceDatabaseSetting : IAttendanceDatabaseSetting
    {
        public string AttendanceCollectionName { get; set ; }
        public string ConnectionString { get; set ; }
        public string DatabaseName { get ; set ; }
    }
}
