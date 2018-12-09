using System.Collections.Generic;
using System.Linq;
using FactoryDataModel;
using FactoryDbViewer.Components;
using FactoryDbViewer.Tables;

namespace FactoryDbViewer
{
    public class Presenter : IPresenter
    {
        public TableTypes CurrentTableType
        {
            get { return _currentTableType; }
            set
            {
                _currentTableType = value;
                UpdateViewTable();
            }
        }

        private TableTypes _currentTableType;

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

            WorkerInformationView workerInformation = TableMapper.WorkerPocoToView(worker);
            workerInformation.Department = department;
            workerInformation.Speciality = speciality;

            _dataModel.InsertWorker(workerInformation);
            UpdateViewTable();
        }

        public void EditWorker(Worker worker)
        {
            DepartmentsView department = _dataModel.GetDepartments().Single(d => d.Name == worker.Department);
            WorkerSpecialitiesView speciality = _dataModel.GetSpecialities().Single(s => s.name == worker.Speciality);

            WorkerInformationView workerInformation = TableMapper.WorkerPocoToView(worker);

            workerInformation.Department = department;
            workerInformation.Speciality = speciality;
            workerInformation.DepartmentId = department.ID;
            workerInformation.SpecialityId = speciality.id;

            _dataModel.UpdateWorker(workerInformation);
            UpdateViewTable();
        }

        public void DeleteWorker(Worker worker)
        {
            WorkerInformationView workerInformation = TableMapper.WorkerPocoToView(worker);

            _dataModel.DeleteWorker(workerInformation);
            UpdateViewTable();
        }

        public List<Worker> GetWorkers()
        {
            return _dataModel.GetWorkers().Select(TableMapper.WorkerViewToPoco).ToList();
        }

        public void AddDepartment(Department department)
        {
            var dep = TableMapper.DepartmentPocoToView(department);

            _dataModel.InsertDepartment(dep);
            UpdateViewTable();
        }

        public void EditDepartment(Department department)
        {
            var dep = TableMapper.DepartmentPocoToView(department);

            _dataModel.UpdateDepartment(dep);
            UpdateViewTable();
        }

        public void DeleteDepartment(Department department)
        {
            var dep = TableMapper.DepartmentPocoToView(department);

            _dataModel.DeleteDepartment(dep);
            UpdateViewTable();
        }

        public void AddSpeciality(Speciality speciality)
        {
            var spec = TableMapper.SpecialityPocoToView(speciality);

            _dataModel.InsertSpeciality(spec);
            UpdateViewTable();
        }

        public void EditSpeciality(Speciality speciality)
        {
            var spec = TableMapper.SpecialityPocoToView(speciality);

            _dataModel.UpdateSpeciality(spec);
            UpdateViewTable();
        }

        public void DeleteSpeciality(Speciality speciality)
        {
            var spec = TableMapper.SpecialityPocoToView(speciality);

            _dataModel.DeleteSpeciality(spec);
            UpdateViewTable();
        }

        public void AddDetail(Detail detail)
        {
            var det = TableMapper.DetailPocoToView(detail);

            _dataModel.InsertDetail(det);
            UpdateViewTable();
        }

        public void EditDetail(Detail detail)
        {
            var det = TableMapper.DetailPocoToView(detail);

            _dataModel.UpdateDetail(det);
            UpdateViewTable();
        }

        public void DeleteDetail(Detail detail)
        {
            var det = TableMapper.DetailPocoToView(detail);

            _dataModel.DeleteDetail(det);
            UpdateViewTable();
        }

        public void AddDailyAccount(DailyAccount dailyAccount)
        {
            var dailyAcc = TableMapper.DailyAccountPocoToView(dailyAccount);

            _dataModel.InsertDailyAccount(dailyAcc);
            UpdateViewTable();
        }

        public void EditDailyAccount(DailyAccount dailyAccount)
        {
            var dailyAcc = TableMapper.DailyAccountPocoToView(dailyAccount);

            _dataModel.UpdateDailyAccount(dailyAcc);
            UpdateViewTable();
        }

        public void DeleteDailyAccount(DailyAccount dailyAccount)
        {
            var dailyAcc = TableMapper.DailyAccountPocoToView(dailyAccount);

            _dataModel.DeleteDailyAccount(dailyAcc);
            UpdateViewTable();
        }

        public void AddMonthAccount(MonthAccount monthAccount)
        {
            var monthAcc = TableMapper.MonthAccountPocoToView(monthAccount);

            _dataModel.InsertDetailsMonthPlan(monthAcc);
            UpdateViewTable();
        }

        public void EditMonthAccount(MonthAccount monthAccount)
        {
            var monthAcc = TableMapper.MonthAccountPocoToView(monthAccount);

            _dataModel.UpdateDetailsMonthPlan(monthAcc);
            UpdateViewTable();
        }

        public void DeleteMonthAccount(MonthAccount monthAccount)
        {
            var monthAcc = TableMapper.MonthAccountPocoToView(monthAccount);

            _dataModel.DeleteDetailsMonthPlan(monthAcc);
            UpdateViewTable();
        }

        public List<Department> GetDepartments()
        {
            return _dataModel.GetDepartments().Select(TableMapper.DepartmentViewToPoco).ToList();
        }

        public List<Speciality> GetSpecilities()
        {
            return _dataModel.GetSpecialities().Select(TableMapper.SpecialityViewToPoco).ToList();
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

        public void UpdateViewTable()
        {
            switch (_currentTableType)
            {
                case TableTypes.Workers:
                    _window.UpdateTable(GetWorkers());
                    break;
                case TableTypes.Departments:
                    _window.UpdateTable(GetDepartments());
                    break;
                case TableTypes.Specialities:
                    _window.UpdateTable(GetSpecilities());
                    break;
                case TableTypes.Details:
                    _window.UpdateTable(GetDetails());
                    break;
                case TableTypes.DailyAccounts:
                    _window.UpdateTable(GetDailyAccounts());
                    break;
                case TableTypes.MonthAccounts:
                    _window.UpdateTable(GetMonthAccounts());
                    break;
            }
            
        }
    }
}
