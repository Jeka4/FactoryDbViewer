using System;
using System.ComponentModel.DataAnnotations;

namespace FactoryDataModel
{
    [MetadataType(typeof(DailyAccountsMetaData))]
    public partial class DailyAccountView
    {
    }

    public class DailyAccountsMetaData
    {
        [Required, Range(0, int.MaxValue)]
        public int workerID { get; set; }
        [Required, Range(0, int.MaxValue)]
        public int detailID { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required, Range(0, int.MaxValue)]
        public int madeCount { get; set; }
        [Required, Range(0, int.MaxValue)]
        public int norm { get; set; }
        [Required, Range(0, int.MaxValue)]
        public int defectCount { get; set; }
    }
}
