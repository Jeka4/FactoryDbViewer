using System;
using System.Linq;

namespace FactoryDataModel
{
    public class DataModel
    {
        public DataModel()
        {
            using (var contex = new DbFactory())
            {
                var xx = contex.WorkerInformationView.ToList();

                var dep = contex.DepartmentsView.Create();
                var spec = contex.WorkerSpecialitiesView.Create();

                var worker = contex.WorkerInformationView.Create();

                spec.name = "Super spec";
                dep.Name = "Top secret";

                worker.firstName = "Пётр";
                worker.middleName = "111";
                worker.lastName = "222";
                worker.address = "333";
                worker.phone = "123-1321";
                worker.category = 2;
                worker.tableNumber = "AAA-BBB-123";
                worker.workStartDate = DateTime.Now;
                worker.speciality = String.Empty;
                worker.department = String.Empty;

                worker.Department = dep;
                worker.Speciality = spec;

                contex.WorkerInformationView.Add(worker);
                try
                {
                    contex.SaveChanges();
                }
                catch (Exception e)
                {
                    var x = 1;
                }
            }
        }
        /*
        public DbSet<DetailsView> GetDetails()
        {
            using (var contex = new DbFactory())
            {
                return contex.DetailsViews;
            }
        }

        public DbSet<WorkerSpecialitiesView> GetSpecialities()
        {
            using (var contex = new DbFactory())
            {
                return contex.WorkerSpecialitiesViews;
            }
        }

        public DbSet<DepartmentsView> GetDepartments()
        {
            using (var contex = new DbFactory())
            {
                return contex.DepartmentsViews;
            }
        }

        public DbSet<WorkerInformationView> GetWorkers()
        {
            using (var contex = new DbFactory())
            {
                return contex.WorkerInformationViews;
            }
        }

        public DbSet<DailyAccountView> GetDailyAccount()
        {
            using (var contex = new DbFactory())
            {
                return contex.DailyAccountViews;
            }
        }

        public DbSet<MonthAccountView> GetMonthAccount()
        {
            using (var contex = new DbFactory())
            {
                return contex.MonthAccountViews;
            }
        }

        public InsertDetail_Result InsertDetail(string name, double blankMass, double detailMass)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));

            if (blankMass <= 0)
                throw new ArgumentException(string.Format("{0} should be positive", nameof(blankMass)));

            if (detailMass <= 0)
                throw new ArgumentOutOfRangeException(string.Format("{0} should be positive", nameof(detailMass)));

            using (var contex = new DbFactory())
            {
                var result = contex.InsertDetail(name, blankMass, detailMass);

                contex.SaveChanges();
                return result.Single();
            }
        }

        public InsertSpeciality_Result InsertSpeciality(string speciality)
        {
            if (string.IsNullOrWhiteSpace(speciality))
                throw new ArgumentException(nameof(speciality));

            using (var contex = new DbFactory())
            {
                var result = contex.InsertSpeciality(speciality);

                contex.SaveChanges();
                return result.Single();
            }
        }

        public InsertDepartment_Result InsertDepartment(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));

            using (var contex = new DbFactory())
            {
                var result = contex.InsertDepartment(name);

                contex.SaveChanges();
                return result.Single();
            }
        }

        public InsertDailyAccount_Result InsertDailyAccount(int workerID, int detailID, DateTime date, int madeCount, int defectCount, int norm)
        {
            if (workerID < 0)
                throw new ArgumentOutOfRangeException(nameof(workerID));

            if (detailID < 0)
                throw new ArgumentOutOfRangeException(nameof(detailID));

            if (madeCount < 0)
                throw new ArgumentOutOfRangeException(nameof(madeCount));

            if (defectCount < 0)
                throw new ArgumentOutOfRangeException(nameof(defectCount));

            if (norm < 0)
                throw new ArgumentOutOfRangeException(nameof(norm));

            using (var contex = new DbFactory())
            {
                var result = contex.InsertDailyAccount(workerID, detailID, date, madeCount, defectCount, norm);

                contex.SaveChanges();
                return result.Single();
            }
        }

        public InsertDetailsMonthPlan_Result InsertDetailsMonthPlan(int departmentID, DateTime date, int detailID, int mustProduce)
        {
            if (departmentID < 0)
                throw new ArgumentOutOfRangeException(nameof(departmentID));

            if (detailID < 0)
                throw new ArgumentOutOfRangeException(nameof(detailID));

            if (mustProduce < 0)
                throw new ArgumentOutOfRangeException(nameof(mustProduce));

            using (var contex = new DbFactory())
            {
                var result = contex.InsertDetailsMonthPlan(departmentID, date, detailID, mustProduce);

                contex.SaveChanges();
                return result.Single();
            }
        }

        public InsertWorker_Result InsertWorker(string firstName, string middleName, string lastName, string tableNumber, int departmentID, int specialityID, int category, DateTime workStartDate, string address, string phone)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException(nameof(firstName));

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException(nameof(lastName));

            if (string.IsNullOrWhiteSpace(middleName))
                throw new ArgumentException(nameof(middleName));

            if (departmentID < 0)
                throw new ArgumentOutOfRangeException(nameof(departmentID));

            if (specialityID < 0)
                throw new ArgumentOutOfRangeException(nameof(specialityID));

            if (category < 0)
                throw new ArgumentOutOfRangeException(nameof(category));

            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException(nameof(address));

            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException(nameof(phone));

            using (var contex = new DbFactory())
            {
                var result = contex.InsertWorker(firstName, middleName, lastName, tableNumber, departmentID, specialityID, category, workStartDate, address, phone);

                contex.SaveChanges();
                return result.Single();
            }
        }

        public UpdateDetail_Result UpdateDetail(int id, string name, double blankMass, double detailMass)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));

            if (blankMass <= 0)
                throw new ArgumentException(string.Format("{0} should be positive", nameof(blankMass)));

            if (detailMass <= 0)
                throw new ArgumentOutOfRangeException(string.Format("{0} should be positive", nameof(detailMass)));

            using (var contex = new DbFactory())
            {
                var result = contex.UpdateDetail(id, name, blankMass, detailMass);

                contex.SaveChanges();
                return result.Single();
            }
        }

        public UpdateSpeciality_Result UpdateSpeciality(int id, string speciality)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            if (string.IsNullOrWhiteSpace(speciality))
                throw new ArgumentException(nameof(speciality));

            using (var contex = new DbFactory())
            {
                var result = contex.UpdateSpeciality(id, speciality);

                contex.SaveChanges();
                return result.Single();
            }
        }

        public UpdateDepartment_Result UpdateDepartment(int id, string name)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));

            using (var contex = new DbFactory())
            {
                var result = contex.UpdateDepartment(id, name);

                contex.SaveChanges();
                return result.Single();
            }
        }

        public UpdateDailyAccount_Result UpdateDailyAccount(int workerID, int detailID, DateTime date, int madeCount, int defectCount, int norm)
        {
            if (workerID < 0)
                throw new ArgumentOutOfRangeException(nameof(workerID));

            if (detailID < 0)
                throw new ArgumentOutOfRangeException(nameof(detailID));

            if (madeCount < 0)
                throw new ArgumentOutOfRangeException(nameof(madeCount));

            if (defectCount < 0)
                throw new ArgumentOutOfRangeException(nameof(defectCount));

            if (norm < 0)
                throw new ArgumentOutOfRangeException(nameof(norm));

            using (var contex = new DbFactory())
            {
                var result = contex.UpdateDailyAccount(workerID, detailID, date, madeCount, defectCount, norm);

                contex.SaveChanges();
                return result.Single();
            }
        }

        public UpdateDetailsMonthPlan_Result UpdateDetailsMonthPlan(int departmentID, DateTime date, int detailID, int mustProduce)
        {
            if (departmentID < 0)
                throw new ArgumentOutOfRangeException(nameof(departmentID));

            if (detailID < 0)
                throw new ArgumentOutOfRangeException(nameof(detailID));

            if (mustProduce < 0)
                throw new ArgumentOutOfRangeException(nameof(mustProduce));

            using (var contex = new DbFactory())
            {
                var result = contex.UpdateDetailsMonthPlan(departmentID, date, detailID, mustProduce);

                contex.SaveChanges();
                return result.Single();
            }
        }

        public UpdateWorker_Result UpdateWorker(int id, string firstName, string middleName, string lastName, string tableNumber, int departmentID, int specialityID, int category, DateTime workStartDate, string address, string phone)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException(nameof(firstName));

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException(nameof(lastName));

            if (string.IsNullOrWhiteSpace(middleName))
                throw new ArgumentException(nameof(middleName));

            if (departmentID < 0)
                throw new ArgumentOutOfRangeException(nameof(departmentID));

            if (specialityID < 0)
                throw new ArgumentOutOfRangeException(nameof(specialityID));

            if (category < 0)
                throw new ArgumentOutOfRangeException(nameof(category));

            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException(nameof(address));

            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException(nameof(phone));

            using (var contex = new DbFactory())
            {
                var result = contex.UpdateWorker(id, firstName, middleName, lastName, tableNumber, departmentID, specialityID, category, workStartDate, address, phone);

                contex.SaveChanges();
                return result.Single();
            }
        }

        public bool DeleteDailyAccount(int workedID, int detailID, DateTime date)
        {
            if (workedID < 0)
                throw new ArgumentOutOfRangeException(nameof(workedID));

            if (detailID < 0)
                throw new ArgumentOutOfRangeException(nameof(detailID));

            using (var contex = new DbFactory())
            {
                var result = contex.DeleteDailyAccount(workedID, detailID, date);

                return result != 0;
            }
        }

        public bool DeleteDepartment(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            using (var contex = new DbFactory())
            {
                var result = contex.DeleteDepartment(id);

                return result != 0;
            }
        }

        public bool DeleteDetail(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            using (var contex = new DbFactory())
            {
                var result = contex.DeleteDetail(id);

                return result != 0;
            }
        }

        public bool DeleteDetailsMonthPlan(int departmentID, DateTime date, int detailID)
        {
            if (departmentID < 0)
                throw new ArgumentOutOfRangeException(nameof(departmentID));

            if (detailID < 0)
                throw new ArgumentOutOfRangeException(nameof(detailID));

            using (var contex = new DbFactory())
            {
                var result = contex.DeleteDetailsMonthPlan(departmentID, date, detailID);

                return result != 0;
            }
        }

        public bool DeleteSpeciality(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            using (var contex = new DbFactory())
            {
                var result = contex.DeleteSpeciality(id);

                return result != 0;
            }
        }

        public bool DeleteWorker(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            using (var contex = new DbFactory())
            {
                var result = contex.DeleteWorker(id);

                return result != 0;
            }
        }
        */
    }
}