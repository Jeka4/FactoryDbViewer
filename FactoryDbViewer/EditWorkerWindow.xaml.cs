using System.Windows;
using FactoryDbViewer.Tables;

namespace FactoryDbViewer
{
    /// <summary>
    /// Логика взаимодействия для EditWorkerWindow.xaml
    /// </summary>
    public partial class EditWorkerWindow : Window
    {
        public EditWorkerWindow(Worker worker)
        {
            InitializeComponent();

            DataContext = worker;
        }

        private void ApplyButton_OnClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
