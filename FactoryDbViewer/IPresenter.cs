using System;
using System.Collections.Generic;
using FactoryDbViewer.Tables;

namespace FactoryDbViewer
{
    interface IPresenter
    {
        List<Worker> GetWorkers();
        List<Department> GetDepartments();
        List<Speciality> GetSpecilities();
        List<Detail> GetDetails();
        List<DailyAccount> GetDailyAccounts();
        List<MonthAccount> GetMonthAccounts();
        void AddWorker(Worker worker);
        void EditWorker(Worker worker);
        void DeleteWorker(Worker worker);
        void AddDepartment(Department department);
        void EditDepartment(Department department);
        void DeleteDepartment(Department department);
        void AddSpeciality(Speciality speciality);
        void EditSpeciality(Speciality speciality);
        void DeleteSpeciality(Speciality speciality);
        void AddDetail(Detail detail);
        void EditDetail(Detail detail);
        void DeleteDetail(Detail detail);
        void AddDailyAccount(DailyAccount dailyAccount);
        void EditDailyAccount(DailyAccount dailyAccount);
        void DeleteDailyAccount(DailyAccount dailyAccount);
        void AddMonthAccount(MonthAccount monthAccount);
        void EditMonthAccount(MonthAccount monthAccount);
        void DeleteMonthAccount(MonthAccount monthAccount);
    }
}
