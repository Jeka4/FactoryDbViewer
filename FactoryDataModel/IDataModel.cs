using System.Collections.Generic;

namespace FactoryDataModel
{
    public interface IDataModel
    {
        List<DetailsView> GetDetails();
        List<WorkerSpecialitiesView> GetSpecialities();
        List<DepartmentsView> GetDepartments();
        List<WorkerInformationView> GetWorkers();
        List<DailyAccountView> GetDailyAccount();
        List<MonthAccountView> GetMonthAccount();
        void InsertDetail(DetailsView detail);
        void InsertSpeciality(WorkerSpecialitiesView speciality);
        void InsertDepartment(DepartmentsView department);
        void InsertDailyAccount(DailyAccountView dailyAccount);
        void InsertDetailsMonthPlan(MonthAccountView monthAccount);
        void InsertWorker(WorkerInformationView worker);
        void UpdateDetail(DetailsView detail);
        void UpdateSpeciality(WorkerSpecialitiesView speciality);
        void UpdateDepartment(DepartmentsView department);
        void UpdateDailyAccount(DailyAccountView dailyAccount);
        void UpdateDetailsMonthPlan(MonthAccountView monthAccount);
        void UpdateWorker(WorkerInformationView worker);
        void DeleteDetail(DetailsView detail);
        void DeleteSpeciality(WorkerSpecialitiesView speciality);
        void DeleteDepartment(DepartmentsView department);
        void DeleteDailyAccount(DailyAccountView dailyAccount);
        void DeleteDetailsMonthPlan(MonthAccountView monthAccount);
        void DeleteWorker(WorkerInformationView worker);
    }
}
