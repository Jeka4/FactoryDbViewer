using System.ComponentModel.DataAnnotations;

namespace FactoryDataModel
{
    [MetadataType(typeof(SpecialitiesMetaData))]
    public partial class WorkerSpecialitiesView
    {
    }

    public class SpecialitiesMetaData
    {
        [Required]
        public int id { get; set; }

        [Required]
        public string name { get; set; }
    }
}