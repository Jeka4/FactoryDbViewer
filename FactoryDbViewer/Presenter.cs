using System;
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
            try
            {
                DepartmentsView department = _dataModel.GetDepartments().Single(d => d.Name == worker.Department);
                WorkerSpecialitiesView speciality = _dataModel.GetSpecialities().Single(s => s.name == worker.Speciality);

                WorkerInformationView workerInformation = TableMapper.WorkerPocoToView(worker);
                workerInformation.Department = department;
                workerInformation.Speciality = speciality;

                _dataModel.InsertWorker(workerInformation);
                UpdateViewTable();
            }
            catch (Exception)
            {
                _window.ShowMessage("Ошибка при добавлении записи");
            }
            finally
            {
                UpdateViewTable();
            }
        }

        public void EditWorker(Worker worker)
        {
            try
            {
                DepartmentsView department = _dataModel.GetDepartments().Single(d => d.Name == worker.Department);
                WorkerSpecialitiesView speciality = _dataModel.GetSpecialities()
                    .Single(s => s.name == worker.Speciality);

                WorkerInformationView workerInformation = TableMapper.WorkerPocoToView(worker);

                workerInformation.Department = department;
                workerInformation.Speciality = speciality;
                workerInformation.DepartmentId = department.ID;
                workerInformation.SpecialityId = speciality.id;

                _dataModel.UpdateWorker(workerInformation);
            }
            catch (Exception)
            {
                _window.ShowMessage("Ошибка при редактировании записи");
            }
            finally
            {
                UpdateViewTable();
            }
        }

        public void DeleteWorker(Worker worker)
        {
            try
            {
                WorkerInformationView workerInformation = TableMapper.WorkerPocoToView(worker);

                _dataModel.DeleteWorker(workerInformation);
                UpdateViewTable();
            }
            catch (Exception)
            {
                _window.ShowMessage("Ошибка при удалении записи");
            }
            finally
            {
                UpdateViewTable();
            }
        }

        public void AddDepartment(Department department)
        {
            try
            {
                var dep = TableMapper.DepartmentPocoToView(department);

                _dataModel.InsertDepartment(dep);
                UpdateViewTable();
            }
            catch (Exception)
            {
                _window.ShowMessage("Ошибка при добавлении записи");
            }
            finally
            {
                UpdateViewTable();
            }
        }

        public void EditDepartment(Department department)
        {
            try
            {
                var dep = TableMapper.DepartmentPocoToView(department);

                _dataModel.UpdateDepartment(dep);
                UpdateViewTable();
            }
            catch (Exception)
            {
                _window.ShowMessage("Ошибка при редактировании записи");
            }
            finally
            {
                UpdateViewTable();
            }
        }

        public void DeleteDepartment(Department department)
        {
            try
            {
                var dep = TableMapper.DepartmentPocoToView(department);

                _dataModel.DeleteDepartment(dep);
                UpdateViewTable();
            }
            catch (Exception)
            {
                _window.ShowMessage("Ошибка при удалении записи");
            }
            finally
            {
                UpdateViewTable();
            }
        }

        public void AddSpeciality(Speciality speciality)
        {
            try
            {
                var spec = TableMapper.SpecialityPocoToView(speciality);

                _dataModel.InsertSpeciality(spec);
                UpdateViewTable();
            }
            catch (Exception)
            {
                _window.ShowMessage("Ошибка при добавлении записи");
            }
            finally
            {
                UpdateViewTable();
            }
        }

        public void EditSpeciality(Speciality speciality)
        {
            try
            {
                var spec = TableMapper.SpecialityPocoToView(speciality);

                _dataModel.UpdateSpeciality(spec);
                UpdateViewTable();
            }
            catch (Exception)
            {
                _window.ShowMessage("Ошибка при редактировании записи");
            }
            finally
            {
                UpdateViewTable();
            }
        }

        public void DeleteSpeciality(Speciality speciality)
        {
            try
            {
                var spec = TableMapper.SpecialityPocoToView(speciality);

                _dataModel.DeleteSpeciality(spec);
                UpdateViewTable();
            }
            catch (Exception)
            {
                _window.ShowMessage("Ошибка при удалении записи");
            }
            finally
            {
                UpdateViewTable();
            }
        }

        public void AddDetail(Detail detail)
        {
            try
            {
                var det = TableMapper.DetailPocoToView(detail);

                _dataModel.InsertDetail(det);
                UpdateViewTable();
            }
            catch (Exception)
            {
                _window.ShowMessage("Ошибка при добавлении записи");
            }
            finally
            {
                UpdateViewTable();
            }
        }

        public void EditDetail(Detail detail)
        {
            try
            {
                var det = TableMapper.DetailPocoToView(detail);

                _dataModel.UpdateDetail(det);
                UpdateViewTable();
            }
            catch (Exception)
            {
                _window.ShowMessage("Ошибка при редактировании записи");
            }
            finally
            {
                UpdateViewTable();
            }
        }

        public void DeleteDetail(Detail detail)
        {
            try
            {
                var det = TableMapper.DetailPocoToView(detail);

                _dataModel.DeleteDetail(det);
                UpdateViewTable();
            }
            catch (Exception)
            {
                _window.ShowMessage("Ошибка при удалении записи");
            }
            finally
            {
                UpdateViewTable();
            }
        }

        public void AddDailyAccount(DailyAccount dailyAccount)
        {
            try
            {
                var dailyAcc = TableMapper.DailyAccountPocoToView(dailyAccount);

                _dataModel.InsertDailyAccount(dailyAcc);
                UpdateViewTable();
            }
            catch (Exception)
            {
                _window.ShowMessage("Ошибка при добавлении записи");
            }
            finally
            {
                UpdateViewTable();
            }
        }

        public void EditDailyAccount(DailyAccount dailyAccount)
        {
            try
            {
                var dailyAcc = TableMapper.DailyAccountPocoToView(dailyAccount);

                _dataModel.UpdateDailyAccount(dailyAcc);
                UpdateViewTable();
            }
            catch (Exception)
            {
                _window.ShowMessage("Ошибка при редактировании записи");
            }
            finally
            {
                UpdateViewTable();
            }
        }

        public void DeleteDailyAccount(DailyAccount dailyAccount)
        {
            try
            {
                var dailyAcc = TableMapper.DailyAccountPocoToView(dailyAccount);

                _dataModel.DeleteDailyAccount(dailyAcc);
                UpdateViewTable();
            }
            catch (Exception)
            {
                _window.ShowMessage("Ошибка при удалении записи");
            }
            finally
            {
                UpdateViewTable();
            }
        }

        public void AddMonthAccount(MonthAccount monthAccount)
        {
            try
            {
                var monthAcc = TableMapper.MonthAccountPocoToView(monthAccount);

                _dataModel.InsertDetailsMonthPlan(monthAcc);
                UpdateViewTable();
            }
            catch (Exception)
            {
                _window.ShowMessage("Ошибка при добавлении записи");
            }
            finally
            {
                UpdateViewTable();
            }
        }

        public void EditMonthAccount(MonthAccount monthAccount)
        {
            try
            {
                var monthAcc = TableMapper.MonthAccountPocoToView(monthAccount);

                _dataModel.UpdateDetailsMonthPlan(monthAcc);
                UpdateViewTable();
            }
            catch (Exception)
            {
                _window.ShowMessage("Ошибка при редактировании записи");
            }
            finally
            {
                UpdateViewTable();
            }
        }

        public void DeleteMonthAccount(MonthAccount monthAccount)
        {
            try
            {
                var monthAcc = TableMapper.MonthAccountPocoToView(monthAccount);

                _dataModel.DeleteDetailsMonthPlan(monthAcc);
                UpdateViewTable();
            }
            catch (Exception)
            {
                _window.ShowMessage("Ошибка при удалении записи");
            }
            finally
            {
                UpdateViewTable();
            }
        }

        public List<Worker> GetWorkers()
        {
            return _dataModel.GetWorkers().Select(TableMapper.WorkerViewToPoco).ToList();
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
            return _dataModel.GetDetails().Select(TableMapper.DetailViewToPoco).ToList();
        }

        public List<DailyAccount> GetDailyAccounts()
        {
            return _dataModel.GetDailyAccount().Select(TableMapper.DailyAccountViewToPoco).ToList();
        }

        public List<MonthAccount> GetMonthAccounts()
        {
            return _dataModel.GetMonthAccount().Select(TableMapper.MonthAccountViewToPoco).ToList();
        }

        public void UpdateViewTable()
        {
            try
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
            catch
            {
                _window.ShowMessage("Ошибка при получении данных");
            }

        }
    }
}
