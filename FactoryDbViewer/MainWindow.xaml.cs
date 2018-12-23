using System;
using System.Collections;
using System.Linq;
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

        public MainWindow(Presenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            //
            TablesListBox.ItemsSource = Enum.GetNames(typeof(TableTypes)).Skip(1).ToArray();
        }

        public void UpdateTable(IEnumerable data)
        {
            DataGrid.ItemsSource = data;
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

        private void AddDetail()
        {
            Detail detail = new Detail();

            var editDetailWindow = new EditDetailWindow(detail);

            editDetailWindow.ShowDialog();

            if (editDetailWindow.DialogResult == false)
                return;

            _presenter.AddDetail(detail);
        }

        private void EditDetail()
        {
            Detail detail = DataGrid.SelectedItem as Detail;

            if (detail == null)
                return;

            var editDetailWindow = new EditDetailWindow(detail);

            editDetailWindow.ShowDialog();

            if (editDetailWindow.DialogResult == false)
                return;

            _presenter.EditDetail(detail);
        }

        private void DeleteDetail()
        {
            Detail detail = DataGrid.SelectedItem as Detail;

            if (detail == null)
                return;

            _presenter.DeleteDetail(detail);
        }

        private void AddDailyAccount()
        {
            DailyAccount dailyAccount = new DailyAccount();

            var editDailyAccountWindow = new EditDailyAccountWindow(dailyAccount);

            editDailyAccountWindow.ShowDialog();

            if (editDailyAccountWindow.DialogResult == false)
                return;

            _presenter.AddDailyAccount(dailyAccount);
        }

        private void EditDailyAccount()
        {
            DailyAccount dailyAccount = DataGrid.SelectedItem as DailyAccount;

            if (dailyAccount == null)
                return;

            var editDailyAccountWindow = new EditDailyAccountWindow(dailyAccount);

            editDailyAccountWindow.ShowDialog();

            if (editDailyAccountWindow.DialogResult == false)
                return;

            _presenter.EditDailyAccount(dailyAccount);
        }

        private void DeleteDailyAccount()
        {
            DailyAccount dailyAccount = DataGrid.SelectedItem as DailyAccount;

            if (dailyAccount == null)
                return;

            _presenter.DeleteDailyAccount(dailyAccount);
        }

        private void AddMonthAccount()
        {
            MonthAccount monthAccount = new MonthAccount();

            var editMonthAccountWindow = new EditMonthAccountWindow(monthAccount);

            editMonthAccountWindow.ShowDialog();

            if (editMonthAccountWindow.DialogResult == false)
                return;

            _presenter.AddMonthAccount(monthAccount);
        }

        private void EditMonthAccount()
        {
            MonthAccount monthAccount = DataGrid.SelectedItem as MonthAccount;

            if (monthAccount == null)
                return;

            var editMonthAccountWindow = new EditMonthAccountWindow(monthAccount);

            editMonthAccountWindow.ShowDialog();

            if (editMonthAccountWindow.DialogResult == false)
                return;

            _presenter.EditMonthAccount(monthAccount);
        }

        private void DeleteMonthAccount()
        {
            MonthAccount monthAccount = DataGrid.SelectedItem as MonthAccount;

            if (monthAccount == null)
                return;

            _presenter.DeleteMonthAccount(monthAccount);
        }

        private void TablesList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var tableType = (TableTypes)Enum.Parse(typeof(TableTypes), TablesListBox.SelectedItem.ToString());

                DataGrid.ItemsSource = null;
                _presenter.CurrentTableType = tableType;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {
            switch (_presenter.CurrentTableType)
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
                case TableTypes.Details:
                AddDetail();
                    break;
                case TableTypes.DailyAccounts:
                    AddDailyAccount();
                    break;
                case TableTypes.MonthAccounts:
                    AddMonthAccount();
                    break;
            }
        }

        private void EditButton_OnClick(object sender, RoutedEventArgs e)
        {
            switch (_presenter.CurrentTableType)
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
                case TableTypes.Details:
                    EditDetail();
                    break;
                case TableTypes.DailyAccounts:
                    EditDailyAccount();
                    break;
                case TableTypes.MonthAccounts:
                    EditMonthAccount();
                    break;
            }
        }

        private void DeleteButton_OnClick(object sender, RoutedEventArgs e)
        {
            switch (_presenter.CurrentTableType)
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
                case TableTypes.Details:
                    DeleteDetail();
                    break;
                case TableTypes.DailyAccounts:
                    DeleteDailyAccount();
                    break;
                case TableTypes.MonthAccounts:
                    DeleteMonthAccount();
                    break;
            }
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(text, "FactoryDbViewer", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
