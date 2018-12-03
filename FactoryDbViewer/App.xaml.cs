using System.Windows;
using FactoryDataModel;

namespace FactoryDbViewer
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //DataModel model = new DataModel();
            DataModel model = new DataModel();
            Presenter presenter = new Presenter(model);
        }
    }
}
