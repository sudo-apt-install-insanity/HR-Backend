namespace HrDatabaseBackend.Model.AttendanceModel
{
    public interface IAttendanceDatabaseSetting
    {
        string AttendanceCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
