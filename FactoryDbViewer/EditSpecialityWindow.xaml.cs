using System.Windows;
using FactoryDbViewer.Tables;

namespace FactoryDbViewer
{
    /// <summary>
    /// Логика взаимодействия для EditSpecialityWindow.xaml
    /// </summary>
    public partial class EditSpecialityWindow : Window
    {
        public EditSpecialityWindow(Speciality speciality)
        {
            InitializeComponent();

            DataContext = speciality;
        }

        private void ApplyButton_OnClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
