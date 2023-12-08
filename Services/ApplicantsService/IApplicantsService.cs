using HrDatabaseBackend.Model.ApplicantsModel;


namespace HrDatabaseBackend.Services.ApplicantsService
{
    public interface IApplicantsService
    {

        List<Applicants> Get();

        Applicants Get(string id);
        Applicants Create(Applicants user);
        void Update(string id, Applicants user);
        void Remove(string id);
    }
}
