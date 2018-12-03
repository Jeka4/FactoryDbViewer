using System.ComponentModel.DataAnnotations;

namespace FactoryDataModel
{
    [MetadataType(typeof(DetailsMetaData))]
    public partial class DetailsView
    {
    }

    public class DetailsMetaData
    {
        [Required]
        public int id { get; set; }

        [Required]
        public string name { get; set; }
    }
}