using System.ComponentModel.DataAnnotations;

namespace FactoryDataModel
{
    [MetadataType(typeof(DepartmentsMetaData))]
    public partial class DepartmentsView
    {
    }

    public class DepartmentsMetaData
    {
        [Required, Range(0, int.MaxValue)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
