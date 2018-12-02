using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using FactoryDbViewer.Tables;

namespace FactoryDbViewer
{
    /// <summary>
    /// Логика взаимодействия для EditDepartmentWindow.xaml
    /// </summary>
    public partial class EditDepartmentWindow : Window
    {
        public EditDepartmentWindow(Department department)
        {
            InitializeComponent();

            DataContext = department;
        }

        private void ApplyButton_OnClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
