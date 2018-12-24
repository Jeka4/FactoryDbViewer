using System;
using System.ComponentModel.DataAnnotations;

namespace FactoryDataModel
{
    [MetadataType(typeof(MonthAccountsMetaData))]
    public partial class MonthAccountView
    {
    }

    public class MonthAccountsMetaData
    {
        [Required, Range(0, int.MaxValue)]
        public int detailID { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required, Range(0, int.MaxValue)]
        public int departmentID { get; set; }
        [Required, Range(0, int.MaxValue)]
        public int mustProduce { get; set; }
    }
}
