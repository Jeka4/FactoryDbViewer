using System.Collections;

namespace FactoryDbViewer
{
    interface IMainWindow
    {
        void Show();
        void UpdateTable(IEnumerable data);
        void ShowMessage(string text);
    }
}
