using System.ComponentModel.DataAnnotations;

namespace FactoryDataModel
{
    [MetadataType(typeof(WorkersMetaData))]
    public partial class WorkerInformationView
    {
    }

    public class WorkersMetaData
    {
        [Required, Range(0, int.MaxValue)]
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
        [Required, Range(0, int.MaxValue)]
        public int category { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string phone { get; set; }
        public System.DateTime workStartDate { get; set; }
        [Required, Range(0, int.MaxValue)]
        public int DepartmentId { get; set; }
        [Required, Range(0, int.MaxValue)]
        public int SpecialityId { get; set; }
    }
}
