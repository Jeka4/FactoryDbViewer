using System;
using System.Collections;
using FactoryDbViewer.Components;

namespace FactoryDbViewer
{
    interface IMainWindow
    {
        void Show();
        void UpdateTable(IEnumerable data);
        void ShowMessage(string text);
    }
}
