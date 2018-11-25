﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FactoryDataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbFactory : DbContext
    {
        public DbFactory()
            : base("name=DbFactory")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DepartmentsView> DepartmentsView { get; set; }
        public virtual DbSet<WorkerInformationView> WorkerInformationView { get; set; }
        public virtual DbSet<WorkerSpecialitiesView> WorkerSpecialitiesView { get; set; }
        public virtual DbSet<DailyAccountView> DailyAccountView { get; set; }
        public virtual DbSet<DetailsView> DetailsView { get; set; }
        public virtual DbSet<MonthAccountView> MonthAccountView { get; set; }
    
        public virtual int DeleteDailyAccount(Nullable<int> workerID, Nullable<int> detailID, Nullable<System.DateTime> date)
        {
            var workerIDParameter = workerID.HasValue ?
                new ObjectParameter("workerID", workerID) :
                new ObjectParameter("workerID", typeof(int));
    
            var detailIDParameter = detailID.HasValue ?
                new ObjectParameter("detailID", detailID) :
                new ObjectParameter("detailID", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteDailyAccount", workerIDParameter, detailIDParameter, dateParameter);
        }
    
        public virtual int DeleteDepartment(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteDepartment", idParameter);
        }
    
        public virtual int DeleteDetail(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteDetail", idParameter);
        }
    
        public virtual int DeleteDetailsMonthPlan(Nullable<int> departmentID, Nullable<System.DateTime> date, Nullable<int> detailID)
        {
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("departmentID", departmentID) :
                new ObjectParameter("departmentID", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var detailIDParameter = detailID.HasValue ?
                new ObjectParameter("detailID", detailID) :
                new ObjectParameter("detailID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteDetailsMonthPlan", departmentIDParameter, dateParameter, detailIDParameter);
        }
    
        public virtual int DeleteSpeciality(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteSpeciality", idParameter);
        }
    
        public virtual int DeleteWorker(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteWorker", idParameter);
        }
    
        public virtual ObjectResult<InsertDailyAccount_Result> InsertDailyAccount(Nullable<int> workerID, Nullable<int> detailID, Nullable<System.DateTime> date, Nullable<int> madeCount, Nullable<int> defectCount, Nullable<int> norm)
        {
            var workerIDParameter = workerID.HasValue ?
                new ObjectParameter("workerID", workerID) :
                new ObjectParameter("workerID", typeof(int));
    
            var detailIDParameter = detailID.HasValue ?
                new ObjectParameter("detailID", detailID) :
                new ObjectParameter("detailID", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var madeCountParameter = madeCount.HasValue ?
                new ObjectParameter("madeCount", madeCount) :
                new ObjectParameter("madeCount", typeof(int));
    
            var defectCountParameter = defectCount.HasValue ?
                new ObjectParameter("defectCount", defectCount) :
                new ObjectParameter("defectCount", typeof(int));
    
            var normParameter = norm.HasValue ?
                new ObjectParameter("norm", norm) :
                new ObjectParameter("norm", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InsertDailyAccount_Result>("InsertDailyAccount", workerIDParameter, detailIDParameter, dateParameter, madeCountParameter, defectCountParameter, normParameter);
        }
    
        public virtual ObjectResult<InsertDepartment_Result> InsertDepartment(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InsertDepartment_Result>("InsertDepartment", nameParameter);
        }
    
        public virtual ObjectResult<InsertDetail_Result> InsertDetail(string name, Nullable<double> blankMass, Nullable<double> detailMass)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var blankMassParameter = blankMass.HasValue ?
                new ObjectParameter("blankMass", blankMass) :
                new ObjectParameter("blankMass", typeof(double));
    
            var detailMassParameter = detailMass.HasValue ?
                new ObjectParameter("detailMass", detailMass) :
                new ObjectParameter("detailMass", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InsertDetail_Result>("InsertDetail", nameParameter, blankMassParameter, detailMassParameter);
        }
    
        public virtual ObjectResult<InsertDetailsMonthPlan_Result> InsertDetailsMonthPlan(Nullable<int> departmentID, Nullable<System.DateTime> date, Nullable<int> detailID, Nullable<int> mustProduce)
        {
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("departmentID", departmentID) :
                new ObjectParameter("departmentID", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var detailIDParameter = detailID.HasValue ?
                new ObjectParameter("detailID", detailID) :
                new ObjectParameter("detailID", typeof(int));
    
            var mustProduceParameter = mustProduce.HasValue ?
                new ObjectParameter("mustProduce", mustProduce) :
                new ObjectParameter("mustProduce", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InsertDetailsMonthPlan_Result>("InsertDetailsMonthPlan", departmentIDParameter, dateParameter, detailIDParameter, mustProduceParameter);
        }
    
        public virtual ObjectResult<InsertSpeciality_Result> InsertSpeciality(string speciality)
        {
            var specialityParameter = speciality != null ?
                new ObjectParameter("speciality", speciality) :
                new ObjectParameter("speciality", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InsertSpeciality_Result>("InsertSpeciality", specialityParameter);
        }
    
        public virtual ObjectResult<InsertWorker_Result> InsertWorker(string firstName, string middleName, string lastName, string tableNumber, Nullable<int> departmentID, Nullable<int> specialityId, Nullable<int> category, Nullable<System.DateTime> workStartDate, string address, string phone)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var middleNameParameter = middleName != null ?
                new ObjectParameter("middleName", middleName) :
                new ObjectParameter("middleName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            var tableNumberParameter = tableNumber != null ?
                new ObjectParameter("tableNumber", tableNumber) :
                new ObjectParameter("tableNumber", typeof(string));
    
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("departmentID", departmentID) :
                new ObjectParameter("departmentID", typeof(int));
    
            var specialityIdParameter = specialityId.HasValue ?
                new ObjectParameter("specialityId", specialityId) :
                new ObjectParameter("specialityId", typeof(int));
    
            var categoryParameter = category.HasValue ?
                new ObjectParameter("category", category) :
                new ObjectParameter("category", typeof(int));
    
            var workStartDateParameter = workStartDate.HasValue ?
                new ObjectParameter("workStartDate", workStartDate) :
                new ObjectParameter("workStartDate", typeof(System.DateTime));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InsertWorker_Result>("InsertWorker", firstNameParameter, middleNameParameter, lastNameParameter, tableNumberParameter, departmentIDParameter, specialityIdParameter, categoryParameter, workStartDateParameter, addressParameter, phoneParameter);
        }
    
        public virtual ObjectResult<UpdateDailyAccount_Result> UpdateDailyAccount(Nullable<int> workerID, Nullable<int> detailID, Nullable<System.DateTime> date, Nullable<int> madeCount, Nullable<int> defectCount, Nullable<int> norm)
        {
            var workerIDParameter = workerID.HasValue ?
                new ObjectParameter("workerID", workerID) :
                new ObjectParameter("workerID", typeof(int));
    
            var detailIDParameter = detailID.HasValue ?
                new ObjectParameter("detailID", detailID) :
                new ObjectParameter("detailID", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var madeCountParameter = madeCount.HasValue ?
                new ObjectParameter("madeCount", madeCount) :
                new ObjectParameter("madeCount", typeof(int));
    
            var defectCountParameter = defectCount.HasValue ?
                new ObjectParameter("defectCount", defectCount) :
                new ObjectParameter("defectCount", typeof(int));
    
            var normParameter = norm.HasValue ?
                new ObjectParameter("norm", norm) :
                new ObjectParameter("norm", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UpdateDailyAccount_Result>("UpdateDailyAccount", workerIDParameter, detailIDParameter, dateParameter, madeCountParameter, defectCountParameter, normParameter);
        }
    
        public virtual ObjectResult<UpdateDepartment_Result> UpdateDepartment(Nullable<int> id, string name)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UpdateDepartment_Result>("UpdateDepartment", idParameter, nameParameter);
        }
    
        public virtual ObjectResult<UpdateDetail_Result> UpdateDetail(Nullable<int> id, string name, Nullable<double> detailMass, Nullable<double> blankMass)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var detailMassParameter = detailMass.HasValue ?
                new ObjectParameter("detailMass", detailMass) :
                new ObjectParameter("detailMass", typeof(double));
    
            var blankMassParameter = blankMass.HasValue ?
                new ObjectParameter("blankMass", blankMass) :
                new ObjectParameter("blankMass", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UpdateDetail_Result>("UpdateDetail", idParameter, nameParameter, detailMassParameter, blankMassParameter);
        }
    
        public virtual ObjectResult<UpdateDetailsMonthPlan_Result> UpdateDetailsMonthPlan(Nullable<int> departmentID, Nullable<System.DateTime> date, Nullable<int> detailID, Nullable<int> mustProduce)
        {
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("departmentID", departmentID) :
                new ObjectParameter("departmentID", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var detailIDParameter = detailID.HasValue ?
                new ObjectParameter("detailID", detailID) :
                new ObjectParameter("detailID", typeof(int));
    
            var mustProduceParameter = mustProduce.HasValue ?
                new ObjectParameter("mustProduce", mustProduce) :
                new ObjectParameter("mustProduce", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UpdateDetailsMonthPlan_Result>("UpdateDetailsMonthPlan", departmentIDParameter, dateParameter, detailIDParameter, mustProduceParameter);
        }
    
        public virtual ObjectResult<UpdateSpeciality_Result> UpdateSpeciality(Nullable<int> id, string name)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UpdateSpeciality_Result>("UpdateSpeciality", idParameter, nameParameter);
        }
    
        public virtual ObjectResult<UpdateWorker_Result> UpdateWorker(Nullable<int> id, string firstName, string middleName, string lastName, string tableNumber, Nullable<int> departmentID, Nullable<int> specialityId, Nullable<int> category, Nullable<System.DateTime> workStartDate, string address, string phone)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var middleNameParameter = middleName != null ?
                new ObjectParameter("middleName", middleName) :
                new ObjectParameter("middleName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            var tableNumberParameter = tableNumber != null ?
                new ObjectParameter("tableNumber", tableNumber) :
                new ObjectParameter("tableNumber", typeof(string));
    
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("departmentID", departmentID) :
                new ObjectParameter("departmentID", typeof(int));
    
            var specialityIdParameter = specialityId.HasValue ?
                new ObjectParameter("specialityId", specialityId) :
                new ObjectParameter("specialityId", typeof(int));
    
            var categoryParameter = category.HasValue ?
                new ObjectParameter("category", category) :
                new ObjectParameter("category", typeof(int));
    
            var workStartDateParameter = workStartDate.HasValue ?
                new ObjectParameter("workStartDate", workStartDate) :
                new ObjectParameter("workStartDate", typeof(System.DateTime));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UpdateWorker_Result>("UpdateWorker", idParameter, firstNameParameter, middleNameParameter, lastNameParameter, tableNumberParameter, departmentIDParameter, specialityIdParameter, categoryParameter, workStartDateParameter, addressParameter, phoneParameter);
        }
    }
}
