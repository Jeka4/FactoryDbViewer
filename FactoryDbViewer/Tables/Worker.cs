namespace FactoryDbViewer.Tables
{
    public class Worker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string TableNumber { get; set; }
        public string Department { get; set; }
        public string Speciality { get; set; }
        public int Category { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public System.DateTime WorkStartDate { get; set; }
        public int DepartmentId { get; set; }
        public int SpecialityId { get; set; }
    }
}
