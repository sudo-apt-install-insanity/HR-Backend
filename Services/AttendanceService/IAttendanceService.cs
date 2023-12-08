using HrDatabaseBackend.Model.AttendanceModel;
using HrDatabaseBackend.Model.EmployeeModel;

namespace HrDatabaseBackend.Services.AttendanceService
{
    public interface IAttendanceService
    {
        List<Attendance> Get();

        Attendance Get(string id);

        Attendance Create(Attendance attendance);
        void Update(string id, Attendance attendance);
        void Remove(string id);
    }
}
