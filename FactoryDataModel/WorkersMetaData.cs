using System.ComponentModel.DataAnnotations;

namespace FactoryDataModel
{
    [MetadataType(typeof(WorkersMetaData))]
    public partial class WorkerInformationView
    {
    }

    public class WorkersMetaData
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string middleName { get; set; }
        [Required]
        public string tableNumber { get; set; }
        [Required]
        public string department { get; set; }
        [Required]
        public string speciality { get; set; }
        [Required]
        public int category { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string phone { get; set; }
        public System.DateTime workStartDate { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        public int SpecialityId { get; set; }
    }
}
