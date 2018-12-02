using System;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Controls;
using FactoryDbViewer.Components;
using FactoryDbViewer.Tables;

namespace FactoryDbViewer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindow
    {
        private IPresenter _presenter;

        private TableTypes _currentTableType;

        public MainWindow(Presenter presenter)
        {
            _currentTableType = TableTypes.Undefined;
            _presenter = presenter;

            InitializeComponent();

            //
            TablesListBox.ItemsSource = new[]
            {
                TableTypes.Workers.ToString(),
                TableTypes.Departments.ToString(),
                TableTypes.Specialities.ToString(),
            };
        }

        private void GetWorkersTable()
        {
            DataGrid.ItemsSource = _presenter.GetWorkers();
        }

        private void AddWorker()
        {
            Worker worker = new Worker();
            var editWorkerWindow = new EditWorkerWindow(worker);

            editWorkerWindow.ShowDialog();

            if (editWorkerWindow.DialogResult == false)
                return;
            
            _presenter.AddWorker(worker);
        }

        private void EditWorker()
        {
            Worker worker = DataGrid.SelectedItem as Worker;

            if(worker == null)
                return;

            var editWorkerWindow = new EditWorkerWindow(worker);

            editWorkerWindow.ShowDialog();

            if (editWorkerWindow.DialogResult == false)
                return;

            _presenter.EditWorker(worker);
        }

        private void DeleteWorker()
        {
            Worker worker = DataGrid.SelectedItem as Worker;

            if (worker == null)
                return;

            _presenter.DeleteWorker(worker);
        }


        private void GetDepartmentsTable()
        {
            DataGrid.ItemsSource = _presenter.GetDepartments();
        }

        private void AddDepartment()
        {
            Department department = new Department();

            var editDepartmentWindow = new EditDepartmentWindow(department);

            editDepartmentWindow.ShowDialog();

            if (editDepartmentWindow.DialogResult == false)
                return;

            _presenter.AddDepartment(department);
        }

        private void EditDepartment()
        {
            Department department = DataGrid.SelectedItem as Department;

            if (department == null)
                return;

            var editDepartmentWindow = new EditDepartmentWindow(department);

            editDepartmentWindow.ShowDialog();

            if (editDepartmentWindow.DialogResult == false)
                return;

            _presenter.EditDepartment(department);
        }

        private void DeleteDepartment()
        {
            Department department = DataGrid.SelectedItem as Department;

            if (department == null)
                return;

            _presenter.DeleteDepartment(department);
        }


        private void GetSpecialitiesTable()
        {
            DataGrid.ItemsSource = _presenter.GetSpecilities();
        }

        private void AddSpeciality()
        {
            Speciality speciality = new Speciality();

            var editSpecialityWindow = new EditSpecialityWindow(speciality);

            editSpecialityWindow.ShowDialog();

            if (editSpecialityWindow.DialogResult == false)
                return;

            _presenter.AddSpeciality(speciality);
        }

        private void EditSpeciality()
        {
            Speciality speciality = DataGrid.SelectedItem as Speciality;

            if (speciality == null)
                return;

            var editSpecialityWindow = new EditSpecialityWindow(speciality);

            editSpecialityWindow.ShowDialog();

            if (editSpecialityWindow.DialogResult == false)
                return;

            _presenter.EditSpeciality(speciality);
        }

        private void DeleteSpeciality()
        {
            Speciality speciality = DataGrid.SelectedItem as Speciality;

            if (speciality == null)
                return;

            _presenter.DeleteSpeciality(speciality);
        }

        private void TablesList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //try
            //{
            var tableType = (TableTypes) Enum.Parse(typeof (TableTypes), TablesListBox.SelectedItem.ToString());

            DataGrid.ItemsSource = null;
            _currentTableType = tableType;

            switch (tableType)
            {
                case TableTypes.Workers:
                    GetWorkersTable();
                    break;
                case TableTypes.Departments:
                    GetDepartmentsTable();
                    break;
                case TableTypes.Specialities:
                    GetSpecialitiesTable();
                    break;
            }
            //}
        }

        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {
            switch (_currentTableType)
            {
                case TableTypes.Workers:
                    AddWorker();
                    break;
                case TableTypes.Departments:
                    AddDepartment();
                    break;
                case TableTypes.Specialities:
                    AddSpeciality();
                    break;
                default:
                    
                    break;
            }
        }

        private void EditButton_OnClick(object sender, RoutedEventArgs e)
        {
            switch (_currentTableType)
            {
                case TableTypes.Workers:
                    EditWorker();
                    break;
                case TableTypes.Departments:
                    EditDepartment();
                    break;
                case TableTypes.Specialities:
                    EditSpeciality();
                    break;
                default:

                    break;
            }
        }

        private void DeleteButton_OnClick(object sender, RoutedEventArgs e)
        {
            switch (_currentTableType)
            {
                case TableTypes.Workers:
                    DeleteWorker();
                    break;
                case TableTypes.Departments:
                    DeleteDepartment();
                    break;
                case TableTypes.Specialities:
                    DeleteSpeciality();
                    break;
                default:

                    break;
            }
        }
    }
}
