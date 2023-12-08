using HrDatabaseBackend.Model.PerformanceModel;
using HrDatabaseBackend.Model.UserModel;

namespace HrDatabaseBackend.Services.PerformanceService
{
    public interface IPerformanceService
    {
        List<Performance> Get();

        Performance Get(string id);
        Performance Getbyemployeeid(string employeeid);
      
        Performance Create(Performance user);
        void Update(string id, Performance user);
        void Updatebyemployeeid(string employeeid, Performance user);
        void Remove(string id);
    }
}
