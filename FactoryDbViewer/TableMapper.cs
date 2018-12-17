using FactoryDataModel;
using FactoryDbViewer.Tables;

namespace FactoryDbViewer
{
    static internal class TableMapper
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

        public static DetailsView DetailPocoToView(Detail poco)
        {
            return new DetailsView
            {
                id = poco.Id,
                name = poco.Name,
                blankMass = poco.BlankMass,
                detailMass = poco.DetailMass
            };
        }

        public static Detail DetailViewToPoco(DetailsView view)
        {
            return new Detail
            {
                Id = view.id,
                Name = view.name,
                BlankMass = view.blankMass,
                DetailMass = view.detailMass
            };
        }

        public static DailyAccountView DailyAccountPocoToView(DailyAccount poco)
        {
            return new DailyAccountView
            {
                workerID = poco.WorkerId,
                detailID = poco.DetailId,
                date = poco.Date,
                madeCount = poco.MadeCount,
                defectCount = poco.DefectCount,
                norm = poco.Norm
            };
        }

        public static DailyAccount DailyAccountViewToPoco(DailyAccountView view)
        {
            return new DailyAccount
            {
                WorkerId = view.workerID,
                DetailId = view.detailID,
                Date = view.date,
                MadeCount = view.madeCount,
                DefectCount = view.defectCount,
                Norm = view.norm
            };
        }

        public static MonthAccountView MonthAccountPocoToView(MonthAccount poco)
        {
            return new MonthAccountView
            {
                departmentID = poco.DepartmentId,
                detailID = poco.DetailId,
                date = poco.Date,
                mustProduce = poco.MustProduce
            };
        }

        public static MonthAccount MonthAccountViewToPoco(MonthAccountView view)
        {
            return new MonthAccount
            {
                DepartmentId = view.departmentID,
                DetailId = view.detailID,
                Date = view.date,
                MustProduce = view.mustProduce
            };
        }
    }
}
