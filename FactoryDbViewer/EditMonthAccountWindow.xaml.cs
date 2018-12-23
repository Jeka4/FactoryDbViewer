using System.Windows;
using FactoryDbViewer.Tables;

namespace FactoryDbViewer
{
    /// <summary>
    /// Логика взаимодействия для EditMonthAccountWindow.xaml
    /// </summary>
    public partial class EditMonthAccountWindow : Window
    {
        public EditMonthAccountWindow(MonthAccount monthAccount)
        {
            InitializeComponent();

            DataContext = monthAccount;
        }

        private void ApplyButton_OnClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
