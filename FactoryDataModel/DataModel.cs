using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;

namespace FactoryDataModel
{
    public class DataModel
    {
        public List<DetailsView> GetDetails()
        {
            using (var contex = new DbFactory())
            { 
                return contex.DetailsView.ToList();
            }
        }

        public List<WorkerSpecialitiesView> GetSpecialities()
        {
            using (var contex = new DbFactory())
            {
                return contex.WorkerSpecialitiesView.ToList();
            }
        }

        public List<DepartmentsView> GetDepartments()
        {
            using (var contex = new DbFactory())
            {
                return contex.DepartmentsView.ToList();
            }
        }

        public List<WorkerInformationView> GetWorkers()
        {
            using (var contex = new DbFactory())
            {
                return contex.WorkerInformationView.ToList();
            }
        }

        public List<DailyAccountView> GetDailyAccount()
        {
            using (var contex = new DbFactory())
            {
                return contex.DailyAccountView.ToList();
            }
        }

        public List<MonthAccountView> GetMonthAccount()
        {
            using (var contex = new DbFactory())
            {
                return contex.MonthAccountView.ToList();
            }
        }

        public void InsertDetail(DetailsView detail)
        {
            using (var contex = new DbFactory())
            {
                contex.DetailsView.Add(detail);

                contex.SaveChanges();
            }
        }

        public void InsertSpeciality(WorkerSpecialitiesView speciality)
        {
            using (var contex = new DbFactory())
            {
                contex.WorkerSpecialitiesView.Add(speciality);

                contex.SaveChanges();
            }
        }

        public void InsertDepartment(DepartmentsView department)
        {
            using (var contex = new DbFactory())
            {
                contex.DepartmentsView.Add(department);

                contex.SaveChanges();
            }
        }

        public void InsertDailyAccount(DailyAccountView dailyAccount)
        {
            using (var contex = new DbFactory())
            {
                contex.DailyAccountView.Add(dailyAccount);

                contex.SaveChanges();
            }
        }

        public void InsertDetailsMonthPlan(MonthAccountView monthAccount)
        {
            using (var contex = new DbFactory())
            {
                contex.MonthAccountView.Add(monthAccount);

                contex.SaveChanges();
            }
        }

        public void InsertWorker(WorkerInformationView worker)
        {
            using (var contex = new DbFactory())
            {
                contex.DepartmentsView.Attach(worker.Department);
                contex.WorkerSpecialitiesView.Attach(worker.Speciality);

                contex.WorkerInformationView.Add(worker);

                contex.SaveChanges();
            }
        }

        public void UpdateDetail(DetailsView detail)
        {
            using (var contex = new DbFactory())
            {
                contex.DetailsView.Attach(detail);
                contex.Entry(detail).State = EntityState.Modified;

                contex.SaveChanges();
            }
        }

        public void UpdateSpeciality(WorkerSpecialitiesView speciality)
        {
            using (var contex = new DbFactory())
            {
                contex.WorkerSpecialitiesView.Attach(speciality);
                contex.Entry(speciality).State = EntityState.Modified;

                contex.SaveChanges();
            }
        }

        public void UpdateDepartment(DepartmentsView department)
        {
            using (var contex = new DbFactory())
            {
                contex.DepartmentsView.Attach(department);
                contex.Entry(department).State = EntityState.Modified;

                contex.SaveChanges();
            }
        }

        public void UpdateDailyAccount(DailyAccountView dailyAccount)
        {
            using (var contex = new DbFactory())
            {
                contex.DailyAccountView.Attach(dailyAccount);
                contex.Entry(dailyAccount).State = EntityState.Modified;

                contex.SaveChanges();
            }
        }

        public void UpdateDetailsMonthPlan(MonthAccountView monthAccount)
        {
            using (var contex = new DbFactory())
            {
                contex.MonthAccountView.Attach(monthAccount);
                contex.Entry(monthAccount).State = EntityState.Modified;

                contex.SaveChanges();
            }
        }

        public void UpdateWorker(WorkerInformationView worker)
        {
            using (var contex = new DbFactory())
            {
                contex.DepartmentsView.Attach(worker.Department);
                contex.WorkerSpecialitiesView.Attach(worker.Speciality);
                contex.WorkerInformationView.Attach(worker);
                
                contex.Entry(worker).State = EntityState.Modified;

                contex.SaveChanges();
            }
        }

        public void DeleteDetail(DetailsView detail)
        {
            using (var contex = new DbFactory())
            {
                contex.DetailsView.Attach(detail);
                contex.DetailsView.Remove(detail);

                contex.SaveChanges();
            }
        }

        public void DeleteSpeciality(WorkerSpecialitiesView speciality)
        {
            using (var contex = new DbFactory())
            {
                contex.WorkerSpecialitiesView.Attach(speciality);
                contex.WorkerSpecialitiesView.Remove(speciality);

                contex.SaveChanges();
            }
        }

        public void DeleteDepartment(DepartmentsView department)
        {
            using (var contex = new DbFactory())
            {
                contex.DepartmentsView.Attach(department);
                contex.DepartmentsView.Remove(department);

                contex.SaveChanges();
            }
        }

        public void DeleteDailyAccount(DailyAccountView dailyAccount)
        {
            using (var contex = new DbFactory())
            {
                contex.DailyAccountView.Attach(dailyAccount);
                contex.DailyAccountView.Remove(dailyAccount);

                contex.SaveChanges();
            }
        }

        public void DeleteDetailsMonthPlan(MonthAccountView monthAccount)
        {
            using (var contex = new DbFactory())
            {
                contex.MonthAccountView.Attach(monthAccount);
                contex.MonthAccountView.Remove(monthAccount);

                contex.SaveChanges();
            }
        }

        public void DeleteWorker(WorkerInformationView worker)
        {
            using (var contex = new DbFactory())
            {
                contex.WorkerInformationView.Attach(worker);
                contex.WorkerInformationView.Remove(worker);

                contex.SaveChanges();
            }
        }
    }
}