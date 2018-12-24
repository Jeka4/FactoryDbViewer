using FactoryDbViewer.Tables;

namespace FactoryDbViewer.Components
{
    internal interface IRequestHandler
    {
        void AddWorker(Worker worker);
        void EditWorker(Worker worker);
        void DeleteWorker(Worker worker);
    }
}
