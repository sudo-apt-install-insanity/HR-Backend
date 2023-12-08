using HrDatabaseBackend.Model.AttendanceModel;
using HrDatabaseBackend.Model.EmployeeModel;
using MongoDB.Driver;

namespace HrDatabaseBackend.Services.AttendanceService
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IMongoCollection<Attendance> _attendance;

        public AttendanceService(IAttendanceDatabaseSetting setting, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(setting.DatabaseName);
            _attendance = database.GetCollection<Attendance>(setting.AttendanceCollectionName);
        }
        public Attendance Create(Attendance attendance)
        {

            _attendance.InsertOne(attendance);
            return attendance;
        }

        public List<Attendance> Get()
        {
            return _attendance.Find(attendance => true).ToList();
        }

        public Attendance Get(string id)
        {
            return _attendance.Find(attendance => attendance.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _attendance.DeleteOne(attendance => attendance.Id == id);
        }

        public void Update(string id, Attendance attendance)
        {
            _attendance.ReplaceOne(attendance => attendance.Id == id, attendance);
        }
    }
}
