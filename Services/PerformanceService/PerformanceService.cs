using HrDatabaseBackend.Model.PerformanceModel;
using HrDatabaseBackend.Model.UserModel;
using MongoDB.Driver;

namespace HrDatabaseBackend.Services.PerformanceService
{
    public class PerformanceService : IPerformanceService
    {
        private readonly IMongoCollection<Performance> _performance;

        public PerformanceService(IPerformanceDatabaseSetting performanceDatabaseSetting, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(performanceDatabaseSetting.DatabaseName);
            _performance = database.GetCollection<Performance>(performanceDatabaseSetting.PerformanceCollectionName);
        }
        Performance IPerformanceService.Create(Performance performance)
        {
            _performance.InsertOne(performance);
            return performance;
        }

        List<Performance> IPerformanceService.Get()
        {
            return _performance.Find(performance => true).ToList();
        }

        Performance IPerformanceService.Get(string id)
        {
            return _performance.Find(_performance => _performance.Id == id).FirstOrDefault();
        }


        Performance IPerformanceService.Getbyemployeeid(string employee_id)
        {
            return _performance.Find(_performance => _performance.employee_id == employee_id).FirstOrDefault();
        }

        void IPerformanceService.Remove(string id)
        {
            _performance.DeleteOne(_performance => _performance.Id == id);
        }

        void IPerformanceService.Update(string id, Performance performance)
        {
            _performance.ReplaceOne(user => user.Id == id, performance);
        }

        void IPerformanceService.Updatebyemployeeid(string employee_id, Performance performance)
        {
            _performance.ReplaceOne(user => user.employee_id == employee_id, performance);
        }
    }
}
