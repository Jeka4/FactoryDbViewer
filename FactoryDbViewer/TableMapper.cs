using FactoryDataModel;
using FactoryDbViewer.Tables;

namespace FactoryDbViewer
{
    static class TableMapper
    {
        public static Worker WorkerViewToPoco(WorkerInformationView view)
        {
            return new Worker
            {
                Id = view.id,
                Department = view.department,
                Speciality = view.speciality,
                Address = view.address,
                Category = view.category,
                FirstName = view.firstName,
                LastName = view.lastName,
                MiddleName = view.middleName,
                Phone = view.phone,
                SpecialityId = view.SpecialityId,
                TableNumber = view.tableNumber,
                WorkStartDate = view.workStartDate,
                DepartmentId = view.DepartmentId
            };
        }

        public static WorkerInformationView WorkerPocoToView(Worker poco)
        {
            return new WorkerInformationView
            {
                id = poco.Id,
                address = poco.Address,
                category = poco.Category,
                firstName = poco.FirstName,
                lastName = poco.LastName,
                middleName = poco.MiddleName,
                phone = poco.Phone,
                tableNumber = poco.TableNumber,
                workStartDate = poco.WorkStartDate,
                speciality = poco.Speciality,
                department = poco.Department
            };
        }

        public static DepartmentsView DepartmentPocoToView(Department poco)
        {
            return new DepartmentsView
            {
                ID = poco.ID,
                Name = poco.Name
            };
        }

        public static Department DepartmentViewToPoco(DepartmentsView view)
        {
            return new Department
            {
                ID = view.ID,
                Name = view.Name
            };
        }

        public static WorkerSpecialitiesView SpecialityPocoToView(Speciality poco)
        {
            return new WorkerSpecialitiesView
            {
                id = poco.Id,
                name = poco.Name
            };
        }

        public static Speciality SpecialityViewToPoco(WorkerSpecialitiesView view)
        {
            return new Speciality
            {
                Id = view.id,
                Name = view.name
            };
        }
    }
}
