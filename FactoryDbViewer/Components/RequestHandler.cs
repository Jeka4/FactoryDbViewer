using System.Linq;
using FactoryDataModel;
using FactoryDbViewer.Tables;

namespace FactoryDbViewer.Components
{
    internal class RequestHandler : IRequestHandler
    {
        private readonly IDataModel _dataModel;

        public RequestHandler(IDataModel dataModel)
        {
            _dataModel = dataModel;
        }

        public void AddWorker(Worker worker)
        {
            DepartmentsView department = _dataModel.GetDepartments().Single(d => d.Name == worker.Department);
            WorkerSpecialitiesView speciality = _dataModel.GetSpecialities().Single(s => s.name == worker.Speciality);

            WorkerInformationView workerInformation = TableMapper.WorkerPocoToView(worker);
            workerInformation.Department = department;
            workerInformation.Speciality = speciality;

            _dataModel.InsertWorker(workerInformation);
        }

        public void EditWorker(Worker worker)
        {
            DepartmentsView department = _dataModel.GetDepartments().Single(d => d.Name == worker.Department);
            WorkerSpecialitiesView speciality = _dataModel.GetSpecialities()
                .Single(s => s.name == worker.Speciality);

            WorkerInformationView workerInformation = TableMapper.WorkerPocoToView(worker);

            workerInformation.Department = department;
            workerInformation.Speciality = speciality;
            workerInformation.DepartmentId = department.ID;
            workerInformation.SpecialityId = speciality.id;

            _dataModel.UpdateWorker(workerInformation);
        }

        public void DeleteWorker(Worker worker)
        {
            WorkerInformationView workerInformation = TableMapper.WorkerPocoToView(worker);

            _dataModel.DeleteWorker(workerInformation);
        }
    }
}
