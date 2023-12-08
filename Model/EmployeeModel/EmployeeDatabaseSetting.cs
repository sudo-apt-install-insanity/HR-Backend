namespace HrDatabaseBackend.Model.EmployeeModel
{
    public class EmployeeDatabaseSetting:IEmployeeDatabaseSetting
    {
        public string EmployeeCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;

       
    }
}
