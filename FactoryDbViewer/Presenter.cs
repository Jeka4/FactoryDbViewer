using System;
using System.Collections.Generic;
using System.Linq;
using FactoryDataModel;
using FactoryDbViewer.Tables;

namespace FactoryDbViewer
{
    public class Presenter : IPresenter
    {
        private readonly IMainWindow _window;

        private readonly DataModel _dataModel;

        public Presenter(DataModel dataModel)
        {
            _dataModel = dataModel;
            _window = new MainWindow(this);

            _window.Show();
        }

        public void AddWorker(Worker worker)
        {
            DepartmentsView department = _dataModel.GetDepartments().Single(d => d.Name == worker.Department);
            WorkerSpecialitiesView speciality = _dataModel.GetSpecialities().Single(s => s.name == worker.Speciality);

            WorkerInformationView workerInformation = new WorkerInformationView
            {
                id = worker.Id,
                address = worker.Address,
                category = worker.Category,
                firstName = worker.FirstName,
                lastName = worker.LastName,
                middleName = worker.MiddleName,
                phone = worker.Phone,
                tableNumber = worker.TableNumber,
                workStartDate = worker.WorkStartDate,
                Department = department,
                Speciality = speciality,
                speciality = worker.Speciality,
                department = worker.Department
            };

            _dataModel.InsertWorker(workerInformation);
        }

        public void EditWorker(Worker worker)
        {
            DepartmentsView department = _dataModel.GetDepartments().Single(d => d.Name == worker.Department);
            WorkerSpecialitiesView speciality = _dataModel.GetSpecialities().Single(s => s.name == worker.Speciality);

            WorkerInformationView workerInformation = new WorkerInformationView
            {
                id = worker.Id,
                address = worker.Address,
                category = worker.Category,
                firstName = worker.FirstName,
                lastName = worker.LastName,
                middleName = worker.MiddleName,
                phone = worker.Phone,
                tableNumber = worker.TableNumber,
                workStartDate = worker.WorkStartDate,
                Department = department,
                Speciality = speciality,
                DepartmentId = department.ID,
                SpecialityId = speciality.id,
                speciality = worker.Speciality,
                department = worker.Department
            };

            _dataModel.UpdateWorker(workerInformation);
        }

        public void DeleteWorker(Worker worker)
        {
            WorkerInformationView workerInformation = new WorkerInformationView
            {
                id = worker.Id,
                address = worker.Address,
                category = worker.Category,
                firstName = worker.FirstName,
                lastName = worker.LastName,
                middleName = worker.MiddleName,
                phone = worker.Phone,
                tableNumber = worker.TableNumber,
                workStartDate = worker.WorkStartDate,
                speciality = worker.Speciality,
                department = worker.Department
            };

            _dataModel.DeleteWorker(workerInformation);
        }

        public List<Worker> GetWorkers()
        {
            var workers = _dataModel.GetWorkers().Select(w => new Worker
            {
                Id = w.id,
                Department = w.department,
                Speciality = w.speciality,
                Address = w.address,
                Category = w.category,
                FirstName = w.firstName,
                LastName = w.lastName,  
                MiddleName = w.middleName,
                Phone = w.phone,
                SpecialityId = w.SpecialityId,
                TableNumber = w.tableNumber,
                WorkStartDate = w.workStartDate,
                DepartmentId = w.DepartmentId
            }).ToList();

            return workers;
        }

        public void AddDepartment(Department department)
        {
            var dep = new DepartmentsView
            {
                ID = department.ID,
                Name = department.Name
            };

            _dataModel.InsertDepartment(dep);
        }

        public void EditDepartment(Department department)
        {
            var dep = new DepartmentsView
            {
                ID = department.ID,
                Name = department.Name
            };

            _dataModel.UpdateDepartment(dep);
        }

        public void DeleteDepartment(Department department)
        {
            var dep = new DepartmentsView
            {
                ID = department.ID,
                Name = department.Name
            };

            _dataModel.DeleteDepartment(dep);
        }

        public void AddSpeciality(Speciality speciality)
        {
            var spec = new WorkerSpecialitiesView
            {
                id = speciality.Id,
                name = speciality.Name
            };

            _dataModel.InsertSpeciality(spec);
        }

        public void EditSpeciality(Speciality speciality)
        {
            var spec = new WorkerSpecialitiesView
            {
                id = speciality.Id,
                name = speciality.Name
            };

            _dataModel.UpdateSpeciality(spec);
        }

        public void DeleteSpeciality(Speciality speciality)
        {
            var spec = new WorkerSpecialitiesView
            {
                id = speciality.Id,
                name = speciality.Name
            };

            _dataModel.DeleteSpeciality(spec);
        }

        public void AddDetail(Detail detail)
        {
            throw new NotImplementedException();
        }

        public void EditDetail(Detail detail)
        {
            throw new NotImplementedException();
        }

        public void DeleteDetail(Detail detail)
        {
            throw new NotImplementedException();
        }

        public void AddDailyAccount(DailyAccount dailyAccount)
        {
            throw new NotImplementedException();
        }

        public void EditDailyAccount(DailyAccount dailyAccount)
        {
            throw new NotImplementedException();
        }

        public void DeleteDailyAccount(DailyAccount dailyAccount)
        {
            throw new NotImplementedException();
        }

        public void AddMonthAccount(MonthAccount monthAccount)
        {
            throw new NotImplementedException();
        }

        public void EditMonthAccount(MonthAccount monthAccount)
        {
            throw new NotImplementedException();
        }

        public void DeleteMonthAccount(MonthAccount monthAccount)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetDepartments()
        {
            var departments = _dataModel.GetDepartments().Select(d => new Department
            {
                ID = d.ID,
                Name = d.Name
            }).ToList();

            return departments;
        }

        public List<Speciality> GetSpecilities()
        {
            var specialities = _dataModel.GetSpecialities().Select(s => new Speciality
            {
                Id =  s.id,
                Name = s.name
            }).ToList();

            return specialities;
        }

        public List<Detail> GetDetails()
        {
            var details = _dataModel.GetDetails().Select(d => new Detail
            {
                Id = d.id,
                Name = d.name,
                BlankMass = d.blankMass,
                DetailMass = d.detailMass
            }).ToList();

            return details;
        }

        public List<DailyAccount> GetDailyAccounts()
        {
            var dailyAccounts = _dataModel.GetDailyAccount().Select(d => new DailyAccount
            {
                WorkerId = d.workerID,
                DetailId = d.detailID,
                Date = d.date,
                DefectCount = d.defectCount,
                MadeCount = d.madeCount,
                Norm = d.norm
            }).ToList();

            return dailyAccounts;
        }

        public List<MonthAccount> GetMonthAccounts()
        {
            var monthAccounts = _dataModel.GetMonthAccount().Select(m => new MonthAccount
            {
                DetailId = m.detailID,
                Date = m.date,
                DepartmentId = m.departmentID,
                MustProduce = m.mustProduce
            }).ToList();

            return monthAccounts;
        }
    }
}
