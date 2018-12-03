using System.ComponentModel.DataAnnotations;

namespace FactoryDataModel
{
    [MetadataType(typeof(DepartmentsMetaData))]
    public partial class DepartmentsView
    {
    }

    public class DepartmentsMetaData
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
