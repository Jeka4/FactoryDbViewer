using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public System.DateTime date { get; set; }
        [Required, Range(0, int.MaxValue)]
        public int departmentID { get; set; }
        [Required, Range(0, int.MaxValue)]
        public int mustProduce { get; set; }
    }
}
