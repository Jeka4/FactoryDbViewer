using System.Windows;
using FactoryDbViewer.Tables;

namespace FactoryDbViewer
{
    /// <summary>
    /// Логика взаимодействия для EditDailyAccountWindow.xaml
    /// </summary>
    public partial class EditDailyAccountWindow : Window
    {
        public EditDailyAccountWindow(DailyAccount dailyAccount)
        {
            InitializeComponent();

            DataContext = dailyAccount;
        }

        private void ApplyButton_OnClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
