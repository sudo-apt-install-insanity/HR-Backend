namespace HrDatabaseBackend.Model.EmployeeModel
{
    public interface IEmployeeDatabaseSetting
    {

        string EmployeeCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
      
    }
}
