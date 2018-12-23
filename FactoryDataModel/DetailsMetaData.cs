using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FactoryDataModel
{
    [MetadataType(typeof(DetailsMetaData))]
    public partial class DetailsView : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var errors = new List<ValidationResult>();

            if(blankMass < detailMass)
                errors.Add(new ValidationResult("Масса заготовки меньше массы детали."));

            return errors;
        }
    }

    public class DetailsMetaData
    {
        [Required, Range(0, int.MaxValue)]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Range(0, 1000)]
        public double blankMass { get; set; }

        [Range(0, 1000)]
        public double detailMass { get; set; }
    }
}