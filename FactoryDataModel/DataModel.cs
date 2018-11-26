using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FactoryDataModel
{
    public class DataModel
    {
        public DataModel()
        {
            /*
            var dep = contex.DepartmentsView.Create();
            var spec = contex.WorkerSpecialitiesView.Create();

            spec.name = "Super spec";
            dep.Name = "Top secret";
            */
            var worker = new WorkerInformationView();

            worker.id = 1;
            worker.firstName = "Иваныч";
            worker.middleName = "111";
            worker.lastName = "222";
            worker.address = "333";
            worker.phone = "123-1321";
            worker.category = 2;
            worker.tableNumber = "AAA-BBB-123";
            worker.workStartDate = DateTime.Now;
            worker.speciality = String.Empty;
            worker.department = String.Empty;

            //worker.Department = dep;
            //worker.Speciality = spec;

            InsertWorker(worker);

        }

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
                var result = contex.DetailsView.Add(detail);

                contex.SaveChanges();
            }
        }

        public void InsertSpeciality(WorkerSpecialitiesView speciality)
        {
            using (var contex = new DbFactory())
            {
                var result = contex.WorkerSpecialitiesView.Add(speciality);

                contex.SaveChanges();
            }
        }

        public void InsertDepartment(DepartmentsView department)
        {
            using (var contex = new DbFactory())
            {
                var result = contex.DepartmentsView.Add(department);

                contex.SaveChanges();
            }
        }

        public void InsertDailyAccount(DailyAccountView dailyAccount)
        {
            using (var contex = new DbFactory())
            {
                var result = contex.DailyAccountView.Add(dailyAccount);

                contex.SaveChanges();
            }
        }

        public void InsertDetailsMonthPlan(MonthAccountView monthAccount)
        {
            using (var contex = new DbFactory())
            {
                var result = contex.MonthAccountView.Add(monthAccount);

                contex.SaveChanges();
            }
        }

        public void InsertWorker(WorkerInformationView worker)
        {
            using (var contex = new DbFactory())
            {
                var result = contex.WorkerInformationView.Add(worker);

                contex.SaveChanges();
            }
        }

        public void UpdateDetail(DetailsView detail) //??????????????
        {
            using (var contex = new DbFactory())
            {
                contex.DetailsView.Attach(detail);

                /*
                var result = contex.DetailsView.Add(detail);
                contex.Entry<DetailsView>(detail).State = EntityState.Modified;
                */
                contex.SaveChanges();
            }
        }

        public void UpdateSpeciality(WorkerSpecialitiesView speciality)
        {
            using (var contex = new DbFactory())
            {
                var result = contex.WorkerSpecialitiesView.Add(speciality);

                contex.SaveChanges();
            }
        }

        public void UpdateDepartment(DepartmentsView department)
        {
            using (var contex = new DbFactory())
            {
                var result = contex.DepartmentsView.Add(department);

                contex.SaveChanges();
            }
        }

        public void UpdateDailyAccount(DailyAccountView dailyAccount)
        {
            using (var contex = new DbFactory())
            {
                var result = contex.DailyAccountView.Add(dailyAccount);

                contex.SaveChanges();
            }
        }

        public void UpdateDetailsMonthPlan(MonthAccountView monthAccount)
        {
            using (var contex = new DbFactory())
            {
                var result = contex.MonthAccountView.Add(monthAccount);

                contex.SaveChanges();
            }
        }

        public void UpdateWorker(WorkerInformationView worker)
        {
            using (var contex = new DbFactory())
            {
                var result = contex.WorkerInformationView.Add(worker);

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